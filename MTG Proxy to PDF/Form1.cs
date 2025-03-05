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

            this.Size = new System.Drawing.Size(500, 200);

            btnGeneratePdf.FlatStyle = FlatStyle.Flat;
            progressBar1.Hide();
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            string sourceFolderPath = "";
            string destinationFolderPath = "";

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                sourceFolderPath = folderDialog.SelectedPath;
                destinationFolderPath = folderDialog.SelectedPath + "/PDF";
            }

            var imageFiles = Directory.GetFiles(sourceFolderPath, "*.png");
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            progressBar1.Maximum = imageFiles.Length;
            progressBar1.Show();

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
                        gfx.DrawImage(image, xPos, yPos, widthInPoints, heightInPoints);

                        string destFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(imageFiles[imageIndex]));
                        //File.Move(imageFiles[imageIndex], destFilePath);

                        imageIndex++;
                        progressBar1.Value++;
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
                            gfx.DrawImage(image, xPos, yPos, widthInPoints, heightInPoints);

                            string destFilePath = Path.Combine(destinationFolderPath, Path.GetFileName(imageFiles[imageIndex]));
                            //File.Move(imageFiles[imageIndex], destFilePath);

                            imageIndex++;
                            progressBar1.Value++;

                        }
                    }
                }
            }

            string outputFile = Path.Combine(sourceFolderPath + "/PDF", $"{textBox1.Text}.pdf");
            pdf.Save(outputFile);
            MessageBox.Show("PDF generation is finished!");
            progressBar1.Hide();
            progressBar1.Value = 0;
        }
    }
}
