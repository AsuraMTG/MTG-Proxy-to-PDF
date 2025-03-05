using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Net.Http;
using System.Net;
using Microsoft.Extensions.Logging;
using System.Management.Instrumentation;
using Newtonsoft.Json;
using MySqlX.XDevAPI;

namespace MTG_Proxy_to_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            this.MinimizeBox = true;

            btnGeneratePdf.FlatStyle = FlatStyle.Flat;
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            labelCounter.Text = "";

            if (textBoxFileName.Text == "")
            {
                MessageBox.Show("Nincs megadva a PDF neve!");
                return;
            }

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            string sourceFolderPath = "";
            string destinationFolderPath = "";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolderPath = folderDialog.SelectedPath;
                destinationFolderPath = folderDialog.SelectedPath + "/PDF";
            }
            else
                return;

            var imageFiles = Directory.GetFiles(sourceFolderPath, "*.png");
            

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            labelCounter.Text = $"0/{imageFiles.Length}";

            PdfDocument pdf = new PdfDocument();

            double widthInCm = 6.35;
            double heightInCm = 8.89;

            double leftMargin = 20;
            double topMargin = 20;

            double widthInPoints = widthInCm * 28.3465;
            double heightInPoints = heightInCm * 28.3465;

            int columns = 3;
            int rows = 3;

            double horizontalSpacing = 10;
            double verticalSpacing = 10;

            double xPos, yPos;
            int imageIndex = 0;

            PdfPage page = pdf.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    xPos = leftMargin + col * (widthInPoints + horizontalSpacing);
                    yPos = topMargin + row * (heightInPoints + verticalSpacing);

                    if (imageIndex < imageFiles.Length)
                    {
                        XImage image = XImage.FromFile(imageFiles[imageIndex]);

                        pictureBoxCard.Image = Image.FromFile(imageFiles[imageIndex]);

                        labelCounter.Text = $"{imageIndex + 1}/{imageFiles.Length}";

                        Application.DoEvents();

                        gfx.DrawImage(image, xPos, yPos, widthInPoints, heightInPoints);

                        imageIndex++;
                    }
                }
            }

            while (imageIndex < imageFiles.Length)
            {
                pdf.AddPage();
                page = pdf.Pages[pdf.Pages.Count - 1];
                gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        if (imageIndex < imageFiles.Length)
                        {
                            xPos = leftMargin + col * (widthInPoints + horizontalSpacing);
                            yPos = topMargin + row * (heightInPoints + verticalSpacing);


                            XImage image = XImage.FromFile(imageFiles[imageIndex]);

                            pictureBoxCard.Image = Image.FromFile(imageFiles[imageIndex]);


                            labelCounter.Text = $"{imageIndex + 1}/{imageFiles.Length}";

                            Application.DoEvents();

                            gfx.DrawImage(image, xPos, yPos, widthInPoints, heightInPoints);

                            imageIndex++;
                        }
                    }
                }
            }

            string outputFile = Path.Combine(sourceFolderPath + "/PDF", $"{textBoxFileName.Text}.pdf");
            pdf.Save(outputFile);
            labelCounter.Text = "PDF generation is Finished!";
            pictureBoxCard.Image = Image.FromFile("Magic_card_back.png");
            textBoxFileName.Text = "";
        }

        private static readonly HttpClient client = new HttpClient();
        public async Task<string> FetchCard(string card, string path)
        {
            try
            {
                string encodedCardName = Uri.EscapeDataString(card);
                string url = $"https://api.scryfall.com/cards/named?fuzzy={encodedCardName}";

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "MTG Proxy to PDF");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    string errorDetails = await response.Content.ReadAsStringAsync();
                    throw new Exception($"HTTP hiba! Státuszkód: {response.StatusCode}, Részletek: {errorDetails}");
                }

                string json = await response.Content.ReadAsStringAsync();
                dynamic cardData = JsonConvert.DeserializeObject(json);

                if (cardData.image_uris == null || cardData.image_uris.png == null)
                {
                    throw new Exception("A kártyához nincs elérhető PNG kép.");
                }

                string pngUrl = cardData.image_uris.png;

                string savePath = path + $"{card}.png";
                int counter = 1;
                while (File.Exists(savePath))
                {
                    savePath = Path.Combine(path + $"{card} ({counter}).png");
                    counter++;
                }

                var imageBytes = await client.GetByteArrayAsync(pngUrl);
                
                File.WriteAllBytes(savePath, imageBytes);
                
                return savePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            labelDownloadFinished.Text = "";
            labelConvertNumber.Text = "";
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            string sourceFolderPath = "";
            string destinationFolderPath = "";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolderPath = folderDialog.SelectedPath;
                destinationFolderPath = folderDialog.SelectedPath + "/Downloaded Images/";
            }
            else
                return;

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            string[] cardNames = textBoxPureList.Lines;

            foreach (var cardName in cardNames)
            {
                if (string.IsNullOrWhiteSpace(cardName))
                    continue;

                string imageFilePath = await FetchCard(cardName, destinationFolderPath);
            }
            labelDownloadFinished.Text = "Download Finished!";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelDownloadFinished.Text = "";
            labelConvertNumber.Text = "";
            var inputList = new List<string>(textBoxDeckList.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None));

            List<string> resultList = DeckListConverter.ProcessList(inputList);

            textBoxPureList.Text = string.Join(Environment.NewLine, resultList);
            labelConvertNumber.Text = $"Converted {resultList.Count} cards";
        }
    }
}
