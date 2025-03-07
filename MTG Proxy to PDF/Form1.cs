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
using System.Text.RegularExpressions;

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
        public async Task<string> FetchCard(string setCode, string collectorNumber, string path)
        {
            try
            {
                string url = $"https://api.scryfall.com/cards/{setCode}/{collectorNumber}";

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("User-Agent", "MTG Proxy to PDF");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    string errorDetails = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"HTTP hiba! Státuszkód: {response.StatusCode}, Részletek: {errorDetails}\nURL: {url}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception($"HTTP hiba! Státuszkód: {response.StatusCode}, Részletek: {errorDetails}");
                }

                string json = await response.Content.ReadAsStringAsync();
                dynamic cardData = JsonConvert.DeserializeObject(json);

                if (cardData.layout == "transform" || cardData.layout == "modal_dfc")
                {
                    string frontImageUrl = cardData.card_faces[0].image_uris.png;
                    string frontImagePath = Path.Combine(path, $"{setCode}-{collectorNumber}-front.png");
                    await DownloadImage(frontImageUrl, frontImagePath);

                    string backImageUrl = cardData.card_faces[1].image_uris.png;
                    string backImagePath = Path.Combine(path, $"{setCode}-{collectorNumber}-back.png");
                    await DownloadImage(backImageUrl, backImagePath);

                    return "Kétoldalas kártya letöltve.";
                }
                else if (cardData.image_uris != null && cardData.image_uris.png != null)
                {
                    string pngUrl = cardData.image_uris.png;
                    string savePath = Path.Combine(path, $"{setCode}-{collectorNumber}.png");
                    await DownloadImage(pngUrl, savePath);

                    return "Kép letöltve.";
                }
                else
                {
                    throw new Exception("A kártyához nincs elérhető PNG kép.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR";
            }
        }

        private async Task DownloadImage(string imageUrl, string savePath)
        {
            try
            {
                var imageBytes = await client.GetByteArrayAsync(imageUrl);

                int counter = 1;
                while (File.Exists(savePath))
                {
                    savePath = Path.Combine(Path.GetDirectoryName(savePath), $"{Path.GetFileNameWithoutExtension(savePath)} ({counter}){Path.GetExtension(savePath)}");
                    counter++;
                }

                File.WriteAllBytes(savePath, imageBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a kép letöltésekor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            labelDownloadFinished.Text = "";
            labelConvertNumber.Text = "";

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            string sourceFolderPath = "";
            string destinationFolderPath = "";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolderPath = folderDialog.SelectedPath;
                destinationFolderPath = folderDialog.SelectedPath + $"/{textBoxFolderName.Text}/";
            }
            else
                return;

            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            string[] cardLines = textBoxDeckList.Lines;

            foreach (var line in cardLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                Match match = Regex.Match(line, @"^(\d+)\s+(.+?)\s*\((\w+)\)\s*(\S+)(?:\s*\*?[A-Za-z]*\*?)?$");

                if (match.Success)
                {
                    int count = int.Parse(match.Groups[1].Value);

                    string setCode = match.Groups[3].Value;

                    string collectorNumber = match.Groups[4].Value;

                    setCode = setCode.Replace("★", "").Trim();
                    collectorNumber = collectorNumber.Replace("★", "").Trim();

                    if (setCode == "PLST" && collectorNumber.Contains("-"))
                    {
                    }
                    else
                    {
                        collectorNumber = collectorNumber.Replace("-", "");
                    }

                    string url = $"https://api.scryfall.com/cards/{setCode}/{collectorNumber}";

                    for (int i = 0; i < count; i++)
                    {
                        try
                        {
                            string imageFilePath = await FetchCard(setCode, collectorNumber, destinationFolderPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Hiba a kártya letöltésekor: {url}\nRészletek: {ex.Message}", "Letöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    labelConvertNumber.Text = $"{Array.IndexOf(cardLines, line) + 1} / {cardLines.Length}";
                }
                else
                {
                    MessageBox.Show($"Nem sikerült feldolgozni a sort: {line}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            labelDownloadFinished.Text = "Download Finished!";
        }
    }
}
