﻿namespace LicencjeApp
{
    partial class NrLicencjiForm
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
            this.AnulujButton = new System.Windows.Forms.Button();
            this.PDFButton = new System.Windows.Forms.Button();
            this.FirmaLabel = new System.Windows.Forms.Label();
            this.ProgramyListBox = new System.Windows.Forms.ListBox();
            this.LicencjeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnulujButton
            // 
            this.AnulujButton.Location = new System.Drawing.Point(13, 227);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(75, 23);
            this.AnulujButton.TabIndex = 0;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // PDFButton
            // 
            this.PDFButton.Location = new System.Drawing.Point(194, 227);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(75, 23);
            this.PDFButton.TabIndex = 1;
            this.PDFButton.Text = "PDF";
            this.PDFButton.UseVisualStyleBackColor = true;
            // 
            // FirmaLabel
            // 
            this.FirmaLabel.AutoSize = true;
            this.FirmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirmaLabel.Location = new System.Drawing.Point(12, 9);
            this.FirmaLabel.Name = "FirmaLabel";
            this.FirmaLabel.Size = new System.Drawing.Size(43, 25);
            this.FirmaLabel.TabIndex = 2;
            this.FirmaLabel.Text = "cos";
            // 
            // ProgramyListBox
            // 
            this.ProgramyListBox.FormattingEnabled = true;
            this.ProgramyListBox.Location = new System.Drawing.Point(17, 57);
            this.ProgramyListBox.Name = "ProgramyListBox";
            this.ProgramyListBox.Size = new System.Drawing.Size(81, 160);
            this.ProgramyListBox.TabIndex = 3;
            // 
            // LicencjeListBox
            // 
            this.LicencjeListBox.FormattingEnabled = true;
            this.LicencjeListBox.Location = new System.Drawing.Point(120, 57);
            this.LicencjeListBox.Name = "LicencjeListBox";
            this.LicencjeListBox.Size = new System.Drawing.Size(149, 160);
            this.LicencjeListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Programy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Licencje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(229, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 13);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "zero";
            // 
            // NrLicencjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicencjeListBox);
            this.Controls.Add(this.ProgramyListBox);
            this.Controls.Add(this.FirmaLabel);
            this.Controls.Add(this.PDFButton);
            this.Controls.Add(this.AnulujButton);
            this.Name = "NrLicencjiForm";
            this.Text = "NrLicencjiForm";
            this.Load += new System.EventHandler(this.NrLicencjiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.Button PDFButton;
        private System.Windows.Forms.Label FirmaLabel;
        private System.Windows.Forms.ListBox ProgramyListBox;
        private System.Windows.Forms.ListBox LicencjeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDLabel;
    }
}