namespace MTG_Proxy_to_PDF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBoxFileName = new System.Windows.Forms.GroupBox();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxDeckList = new System.Windows.Forms.TextBox();
            this.groupBoxDeckList = new System.Windows.Forms.GroupBox();
            this.labelConvertNumber = new System.Windows.Forms.Label();
            this.textBoxFolderName = new System.Windows.Forms.TextBox();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.buttonDownloadAndGenerate = new System.Windows.Forms.Button();
            this.pictureBoxScryFall = new System.Windows.Forms.PictureBox();
            this.labelScryFall = new System.Windows.Forms.Label();
            this.labelFolderAndFileName = new System.Windows.Forms.Label();
            this.textBoxFolderAndFileName = new System.Windows.Forms.TextBox();
            this.groupBoxFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.groupBoxDeckList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScryFall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeneratePdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePdf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGeneratePdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneratePdf.Location = new System.Drawing.Point(0, 420);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(694, 31);
            this.btnGeneratePdf.TabIndex = 1;
            this.btnGeneratePdf.Text = "Generate PDF";
            this.btnGeneratePdf.UseVisualStyleBackColor = false;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFileName.Location = new System.Drawing.Point(7, 24);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(6);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(75, 16);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "File Name: ";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFileName.Location = new System.Drawing.Point(91, 21);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(585, 22);
            this.textBoxFileName.TabIndex = 3;
            // 
            // groupBoxFileName
            // 
            this.groupBoxFileName.Controls.Add(this.textBoxFileName);
            this.groupBoxFileName.Controls.Add(this.labelFileName);
            this.groupBoxFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxFileName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFileName.Name = "groupBoxFileName";
            this.groupBoxFileName.Size = new System.Drawing.Size(694, 65);
            this.groupBoxFileName.TabIndex = 4;
            this.groupBoxFileName.TabStop = false;
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCard.Image")));
            this.pictureBoxCard.Location = new System.Drawing.Point(10, 74);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(255, 340);
            this.pictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCard.TabIndex = 6;
            this.pictureBoxCard.TabStop = false;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCounter.Location = new System.Drawing.Point(273, 360);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(6);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(51, 16);
            this.labelCounter.TabIndex = 4;
            this.labelCounter.Text = "Hidden";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDownload.Location = new System.Drawing.Point(276, 329);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(203, 29);
            this.buttonDownload.TabIndex = 9;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxDeckList
            // 
            this.textBoxDeckList.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxDeckList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDeckList.Location = new System.Drawing.Point(6, 21);
            this.textBoxDeckList.Multiline = true;
            this.textBoxDeckList.Name = "textBoxDeckList";
            this.textBoxDeckList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeckList.Size = new System.Drawing.Size(397, 166);
            this.textBoxDeckList.TabIndex = 0;
            // 
            // groupBoxDeckList
            // 
            this.groupBoxDeckList.Controls.Add(this.textBoxDeckList);
            this.groupBoxDeckList.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDeckList.Location = new System.Drawing.Point(277, 74);
            this.groupBoxDeckList.Name = "groupBoxDeckList";
            this.groupBoxDeckList.Size = new System.Drawing.Size(405, 193);
            this.groupBoxDeckList.TabIndex = 12;
            this.groupBoxDeckList.TabStop = false;
            this.groupBoxDeckList.Text = "Decklist:";
            // 
            // labelConvertNumber
            // 
            this.labelConvertNumber.AutoSize = true;
            this.labelConvertNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConvertNumber.Location = new System.Drawing.Point(480, 360);
            this.labelConvertNumber.Margin = new System.Windows.Forms.Padding(6);
            this.labelConvertNumber.Name = "labelConvertNumber";
            this.labelConvertNumber.Size = new System.Drawing.Size(51, 16);
            this.labelConvertNumber.TabIndex = 14;
            this.labelConvertNumber.Text = "Hidden";
            // 
            // textBoxFolderName
            // 
            this.textBoxFolderName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFolderName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFolderName.Location = new System.Drawing.Point(276, 301);
            this.textBoxFolderName.Name = "textBoxFolderName";
            this.textBoxFolderName.Size = new System.Drawing.Size(203, 22);
            this.textBoxFolderName.TabIndex = 4;
            // 
            // labelFolderName
            // 
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFolderName.Location = new System.Drawing.Point(274, 276);
            this.labelFolderName.Margin = new System.Windows.Forms.Padding(6);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(92, 16);
            this.labelFolderName.TabIndex = 4;
            this.labelFolderName.Text = "Folder Name: ";
            // 
            // buttonDownloadAndGenerate
            // 
            this.buttonDownloadAndGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadAndGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDownloadAndGenerate.Location = new System.Drawing.Point(483, 329);
            this.buttonDownloadAndGenerate.Name = "buttonDownloadAndGenerate";
            this.buttonDownloadAndGenerate.Size = new System.Drawing.Size(203, 29);
            this.buttonDownloadAndGenerate.TabIndex = 15;
            this.buttonDownloadAndGenerate.Text = "Download and  Generate";
            this.buttonDownloadAndGenerate.UseVisualStyleBackColor = false;
            this.buttonDownloadAndGenerate.Click += new System.EventHandler(this.buttonDownloadAndGenerate_Click);
            // 
            // pictureBoxScryFall
            // 
            this.pictureBoxScryFall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScryFall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxScryFall.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScryFall.Image")));
            this.pictureBoxScryFall.Location = new System.Drawing.Point(626, 364);
            this.pictureBoxScryFall.Name = "pictureBoxScryFall";
            this.pictureBoxScryFall.Size = new System.Drawing.Size(56, 50);
            this.pictureBoxScryFall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScryFall.TabIndex = 16;
            this.pictureBoxScryFall.TabStop = false;
            this.pictureBoxScryFall.Click += new System.EventHandler(this.pictureBoxScryFall_Click);
            // 
            // labelScryFall
            // 
            this.labelScryFall.AutoSize = true;
            this.labelScryFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScryFall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelScryFall.Location = new System.Drawing.Point(274, 385);
            this.labelScryFall.Margin = new System.Windows.Forms.Padding(6);
            this.labelScryFall.Name = "labelScryFall";
            this.labelScryFall.Size = new System.Drawing.Size(318, 26);
            this.labelScryFall.TabIndex = 17;
            this.labelScryFall.Text = "Images provided by scryfall API";
            // 
            // labelFolderAndFileName
            // 
            this.labelFolderAndFileName.AutoSize = true;
            this.labelFolderAndFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFolderAndFileName.Location = new System.Drawing.Point(486, 276);
            this.labelFolderAndFileName.Margin = new System.Windows.Forms.Padding(6);
            this.labelFolderAndFileName.Name = "labelFolderAndFileName";
            this.labelFolderAndFileName.Size = new System.Drawing.Size(137, 16);
            this.labelFolderAndFileName.TabIndex = 18;
            this.labelFolderAndFileName.Text = "Folder and File name:";
            // 
            // textBoxFolderAndFileName
            // 
            this.textBoxFolderAndFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFolderAndFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFolderAndFileName.Location = new System.Drawing.Point(483, 301);
            this.textBoxFolderAndFileName.Name = "textBoxFolderAndFileName";
            this.textBoxFolderAndFileName.Size = new System.Drawing.Size(203, 22);
            this.textBoxFolderAndFileName.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.pictureBoxScryFall);
            this.Controls.Add(this.labelConvertNumber);
            this.Controls.Add(this.labelFolderAndFileName);
            this.Controls.Add(this.textBoxFolderAndFileName);
            this.Controls.Add(this.labelScryFall);
            this.Controls.Add(this.buttonDownloadAndGenerate);
            this.Controls.Add(this.labelFolderName);
            this.Controls.Add(this.textBoxFolderName);
            this.Controls.Add(this.groupBoxDeckList);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.groupBoxFileName);
            this.Controls.Add(this.btnGeneratePdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MTG Proxy to PDF";
            this.groupBoxFileName.ResumeLayout(false);
            this.groupBoxFileName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.groupBoxDeckList.ResumeLayout(false);
            this.groupBoxDeckList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScryFall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeneratePdf;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBoxFileName;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxDeckList;
        private System.Windows.Forms.GroupBox groupBoxDeckList;
        private System.Windows.Forms.Label labelConvertNumber;
        private System.Windows.Forms.TextBox textBoxFolderName;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Button buttonDownloadAndGenerate;
        private System.Windows.Forms.PictureBox pictureBoxScryFall;
        private System.Windows.Forms.Label labelScryFall;
        private System.Windows.Forms.Label labelFolderAndFileName;
        private System.Windows.Forms.TextBox textBoxFolderAndFileName;
    }
}

