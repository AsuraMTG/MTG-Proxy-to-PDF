﻿namespace MTG_Proxy_to_PDF
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
            this.fileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.labelCounter = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDeckList = new System.Windows.Forms.TextBox();
            this.textBoxPureList = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileName.Location = new System.Drawing.Point(7, 24);
            this.fileName.Margin = new System.Windows.Forms.Padding(6);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(75, 16);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "File Name: ";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFileName.Location = new System.Drawing.Point(91, 21);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(536, 22);
            this.textBoxFileName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.fileName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            this.labelCounter.Location = new System.Drawing.Point(274, 398);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(6);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(0, 16);
            this.labelCounter.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPureList);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(482, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 237);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDeckList
            // 
            this.textBoxDeckList.Location = new System.Drawing.Point(277, 74);
            this.textBoxDeckList.Multiline = true;
            this.textBoxDeckList.Name = "textBoxDeckList";
            this.textBoxDeckList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeckList.Size = new System.Drawing.Size(199, 266);
            this.textBoxDeckList.TabIndex = 0;
            // 
            // textBoxPureList
            // 
            this.textBoxPureList.Location = new System.Drawing.Point(6, 21);
            this.textBoxPureList.Multiline = true;
            this.textBoxPureList.Name = "textBoxPureList";
            this.textBoxPureList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPureList.Size = new System.Drawing.Size(188, 210);
            this.textBoxPureList.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.textBoxDeckList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeneratePdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MTG Proxy to PDF";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGeneratePdf;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDeckList;
        private System.Windows.Forms.TextBox textBoxPureList;
    }
}

