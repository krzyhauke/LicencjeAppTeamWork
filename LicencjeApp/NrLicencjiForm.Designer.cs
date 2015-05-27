namespace LicencjeApp
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
            this.components = new System.ComponentModel.Container();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.PDFButton = new System.Windows.Forms.Button();
            this.FirmaLabel = new System.Windows.Forms.Label();
            this.ProgramyListBox = new System.Windows.Forms.ListBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.LicencjeListBox = new System.Windows.Forms.ListBox();
            this.licencjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.licencjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.LicencjaTableAdapter();
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.licencjeQueryToolStrip = new System.Windows.Forms.ToolStrip();
            this.idfirmyToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idfirmyToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.licencjeQueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).BeginInit();
            this.licencjeQueryToolStrip.SuspendLayout();
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
            this.ProgramyListBox.DataSource = this.programBindingSource;
            this.ProgramyListBox.DisplayMember = "Nazwa";
            this.ProgramyListBox.FormattingEnabled = true;
            this.ProgramyListBox.Location = new System.Drawing.Point(17, 57);
            this.ProgramyListBox.Name = "ProgramyListBox";
            this.ProgramyListBox.Size = new System.Drawing.Size(81, 160);
            this.ProgramyListBox.TabIndex = 3;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.licencjeDataSet;
            // 
            // licencjeDataSet
            // 
            this.licencjeDataSet.DataSetName = "LicencjeDataSet";
            this.licencjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LicencjeListBox
            // 
            this.LicencjeListBox.FormattingEnabled = true;
            this.LicencjeListBox.Location = new System.Drawing.Point(120, 57);
            this.LicencjeListBox.Name = "LicencjeListBox";
            this.LicencjeListBox.Size = new System.Drawing.Size(149, 160);
            this.LicencjeListBox.TabIndex = 4;
            this.LicencjeListBox.SelectedIndexChanged += new System.EventHandler(this.LicencjeListBox_SelectedIndexChanged);
            // 
            // licencjaBindingSource
            // 
            this.licencjaBindingSource.DataMember = "Licencja";
            this.licencjaBindingSource.DataSource = this.licencjeDataSet;
            this.licencjaBindingSource.Filter = "";
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
            // licencjaTableAdapter
            // 
            this.licencjaTableAdapter.ClearBeforeFill = true;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // licencjeQueryToolStrip
            // 
            this.licencjeQueryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idfirmyToolStripLabel,
            this.idfirmyToolStripTextBox,
            this.licencjeQueryToolStripButton});
            this.licencjeQueryToolStrip.Location = new System.Drawing.Point(0, 0);
            this.licencjeQueryToolStrip.Name = "licencjeQueryToolStrip";
            this.licencjeQueryToolStrip.Size = new System.Drawing.Size(289, 25);
            this.licencjeQueryToolStrip.TabIndex = 9;
            this.licencjeQueryToolStrip.Text = "licencjeQueryToolStrip";
            this.licencjeQueryToolStrip.Visible = false;
            // 
            // idfirmyToolStripLabel
            // 
            this.idfirmyToolStripLabel.Name = "idfirmyToolStripLabel";
            this.idfirmyToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.idfirmyToolStripLabel.Text = "idfirmy:";
            this.idfirmyToolStripLabel.Visible = false;
            // 
            // idfirmyToolStripTextBox
            // 
            this.idfirmyToolStripTextBox.Name = "idfirmyToolStripTextBox";
            this.idfirmyToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.idfirmyToolStripTextBox.Visible = false;
            // 
            // licencjeQueryToolStripButton
            // 
            this.licencjeQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.licencjeQueryToolStripButton.Name = "licencjeQueryToolStripButton";
            this.licencjeQueryToolStripButton.Size = new System.Drawing.Size(86, 22);
            this.licencjeQueryToolStripButton.Text = "LicencjeQuery";
            this.licencjeQueryToolStripButton.Click += new System.EventHandler(this.licencjeQueryToolStripButton_Click);
            // 
            // NrLicencjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 270);
            this.Controls.Add(this.licencjeQueryToolStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).EndInit();
            this.licencjeQueryToolStrip.ResumeLayout(false);
            this.licencjeQueryToolStrip.PerformLayout();
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
        private LicencjeDataSet licencjeDataSet;
        private System.Windows.Forms.BindingSource licencjaBindingSource;
        private LicencjeDataSetTableAdapters.LicencjaTableAdapter licencjaTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private LicencjeDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.ToolStrip licencjeQueryToolStrip;
        private System.Windows.Forms.ToolStripLabel idfirmyToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idfirmyToolStripTextBox;
        private System.Windows.Forms.ToolStripButton licencjeQueryToolStripButton;
    }
}