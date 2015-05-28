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
            this.licencjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.licencjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.LicencjaTableAdapter();
            this.licencjeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.tableAdapterManager = new LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager();
            this.nUMER_LICENCJIListBox = new System.Windows.Forms.ListBox();
            this.programDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AnulujButton
            // 
            this.AnulujButton.Location = new System.Drawing.Point(17, 292);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(75, 23);
            this.AnulujButton.TabIndex = 0;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // PDFButton
            // 
            this.PDFButton.Location = new System.Drawing.Point(443, 292);
            this.PDFButton.Name = "PDFButton";
            this.PDFButton.Size = new System.Drawing.Size(75, 23);
            this.PDFButton.TabIndex = 1;
            this.PDFButton.Text = "PDF";
            this.PDFButton.UseVisualStyleBackColor = true;
            this.PDFButton.Click += new System.EventHandler(this.PDFButton_Click);
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
            // licencjaBindingSource
            // 
            this.licencjaBindingSource.DataMember = "Licencja";
            this.licencjaBindingSource.DataSource = this.licencjeDataSet;
            this.licencjaBindingSource.Filter = "";
            // 
            // licencjeDataSet
            // 
            this.licencjeDataSet.DataSetName = "LicencjeDataSet";
            this.licencjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.licencjeDataSet;
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
            this.label2.Location = new System.Drawing.Point(181, 41);
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
            // licencjeDataSetBindingSource
            // 
            this.licencjeDataSetBindingSource.DataSource = this.licencjeDataSet;
            this.licencjeDataSetBindingSource.Position = 0;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmyTableAdapter = null;
            this.tableAdapterManager.LicencjaTableAdapter = this.licencjaTableAdapter;
            this.tableAdapterManager.ModulyTableAdapter = null;
            this.tableAdapterManager.PozycjaTableAdapter = null;
            this.tableAdapterManager.ProgramTableAdapter = this.programTableAdapter;
            this.tableAdapterManager.UpdateOrder = LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nUMER_LICENCJIListBox
            // 
            this.nUMER_LICENCJIListBox.FormattingEnabled = true;
            this.nUMER_LICENCJIListBox.Location = new System.Drawing.Point(184, 61);
            this.nUMER_LICENCJIListBox.Name = "nUMER_LICENCJIListBox";
            this.nUMER_LICENCJIListBox.Size = new System.Drawing.Size(334, 225);
            this.nUMER_LICENCJIListBox.TabIndex = 9;
            // 
            // programDataGridView
            // 
            this.programDataGridView.AllowUserToResizeColumns = false;
            this.programDataGridView.AllowUserToResizeRows = false;
            this.programDataGridView.AutoGenerateColumns = false;
            this.programDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.programDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.programDataGridView.ColumnHeadersHeight = 33;
            this.programDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.programDataGridView.ColumnHeadersVisible = false;
            this.programDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nazwa});
            this.programDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.programDataGridView.DataSource = this.programBindingSource;
            this.programDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.programDataGridView.EnableHeadersVisualStyles = false;
            this.programDataGridView.Location = new System.Drawing.Point(17, 61);
            this.programDataGridView.MultiSelect = false;
            this.programDataGridView.Name = "programDataGridView";
            this.programDataGridView.ReadOnly = true;
            this.programDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.programDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.programDataGridView.RowHeadersVisible = false;
            this.programDataGridView.Size = new System.Drawing.Size(152, 225);
            this.programDataGridView.TabIndex = 10;
            this.programDataGridView.Click += new System.EventHandler(this.programDataGridView_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazwa.DataPropertyName = "Nazwa";
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // NrLicencjiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 325);
            this.Controls.Add(this.programDataGridView);
            this.Controls.Add(this.nUMER_LICENCJIListBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirmaLabel);
            this.Controls.Add(this.PDFButton);
            this.Controls.Add(this.AnulujButton);
            this.Name = "NrLicencjiForm";
            this.Text = "NrLicencjiForm";
            this.Load += new System.EventHandler(this.NrLicencjiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.Button PDFButton;
        private System.Windows.Forms.Label FirmaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDLabel;
        private LicencjeDataSet licencjeDataSet;
        private System.Windows.Forms.BindingSource licencjaBindingSource;
        private LicencjeDataSetTableAdapters.LicencjaTableAdapter licencjaTableAdapter;
        private System.Windows.Forms.BindingSource licencjeDataSetBindingSource;
        private System.Windows.Forms.BindingSource programBindingSource;
        private LicencjeDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private LicencjeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox nUMER_LICENCJIListBox;
        private System.Windows.Forms.DataGridView programDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
    }
}