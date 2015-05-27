namespace LicencjeApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.firmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.FirmyTableAdapter();
            this.tableAdapterManager = new LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager();
            this.licencjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.LicencjaTableAdapter();
            this.modulyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ModulyTableAdapter();
            this.pozycjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.PozycjaTableAdapter();
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.firmyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.firmyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.firmyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licencjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pozycjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingNavigator)).BeginInit();
            this.firmyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // licencjeDataSet
            // 
            this.licencjeDataSet.DataSetName = "LicencjeDataSet";
            this.licencjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmyBindingSource
            // 
            this.firmyBindingSource.DataMember = "Firmy";
            this.firmyBindingSource.DataSource = this.licencjeDataSet;
            // 
            // firmyTableAdapter
            // 
            this.firmyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmyTableAdapter = this.firmyTableAdapter;
            this.tableAdapterManager.LicencjaTableAdapter = this.licencjaTableAdapter;
            this.tableAdapterManager.ModulyTableAdapter = this.modulyTableAdapter;
            this.tableAdapterManager.PozycjaTableAdapter = this.pozycjaTableAdapter;
            this.tableAdapterManager.ProgramTableAdapter = this.programTableAdapter;
            this.tableAdapterManager.UpdateOrder = LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // licencjaTableAdapter
            // 
            this.licencjaTableAdapter.ClearBeforeFill = true;
            // 
            // modulyTableAdapter
            // 
            this.modulyTableAdapter.ClearBeforeFill = true;
            // 
            // pozycjaTableAdapter
            // 
            this.pozycjaTableAdapter.ClearBeforeFill = true;
            // 
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // firmyBindingNavigator
            // 
            this.firmyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.firmyBindingNavigator.BindingSource = this.firmyBindingSource;
            this.firmyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.firmyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.firmyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.firmyBindingNavigatorSaveItem});
            this.firmyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.firmyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.firmyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.firmyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.firmyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.firmyBindingNavigator.Name = "firmyBindingNavigator";
            this.firmyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.firmyBindingNavigator.Size = new System.Drawing.Size(1126, 25);
            this.firmyBindingNavigator.TabIndex = 0;
            this.firmyBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // firmyBindingNavigatorSaveItem
            // 
            this.firmyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firmyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("firmyBindingNavigatorSaveItem.Image")));
            this.firmyBindingNavigatorSaveItem.Name = "firmyBindingNavigatorSaveItem";
            this.firmyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.firmyBindingNavigatorSaveItem.Text = "Save Data";
            this.firmyBindingNavigatorSaveItem.Click += new System.EventHandler(this.firmyBindingNavigatorSaveItem_Click);
            // 
            // firmyDataGridView
            // 
            this.firmyDataGridView.AutoGenerateColumns = false;
            this.firmyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.firmyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.firmyDataGridView.DataSource = this.firmyBindingSource;
            this.firmyDataGridView.Location = new System.Drawing.Point(0, 28);
            this.firmyDataGridView.Name = "firmyDataGridView";
            this.firmyDataGridView.Size = new System.Drawing.Size(506, 392);
            this.firmyDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAZWA";
            this.dataGridViewTextBoxColumn2.HeaderText = "NAZWA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIP";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ADRES";
            this.dataGridViewTextBoxColumn4.HeaderText = "ADRES";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Miejscowosc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Miejscowosc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefon";
            this.dataGridViewTextBoxColumn7.HeaderText = "telefon";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // licencjaBindingSource
            // 
            this.licencjaBindingSource.DataMember = "Licencja";
            this.licencjaBindingSource.DataSource = this.licencjeDataSet;
            // 
            // modulyBindingSource
            // 
            this.modulyBindingSource.DataMember = "Moduly";
            this.modulyBindingSource.DataSource = this.licencjeDataSet;
            // 
            // pozycjaBindingSource
            // 
            this.pozycjaBindingSource.DataMember = "Pozycja";
            this.pozycjaBindingSource.DataSource = this.licencjeDataSet;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataMember = "Program";
            this.programBindingSource.DataSource = this.licencjeDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PornTest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firmyDataGridView);
            this.Controls.Add(this.firmyBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingNavigator)).EndInit();
            this.firmyBindingNavigator.ResumeLayout(false);
            this.firmyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LicencjeDataSet licencjeDataSet;
        private System.Windows.Forms.BindingSource firmyBindingSource;
        private LicencjeDataSetTableAdapters.FirmyTableAdapter firmyTableAdapter;
        private LicencjeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator firmyBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton firmyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView firmyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private LicencjeDataSetTableAdapters.LicencjaTableAdapter licencjaTableAdapter;
        private System.Windows.Forms.BindingSource licencjaBindingSource;
        private LicencjeDataSetTableAdapters.ModulyTableAdapter modulyTableAdapter;
        private System.Windows.Forms.BindingSource modulyBindingSource;
        private LicencjeDataSetTableAdapters.PozycjaTableAdapter pozycjaTableAdapter;
        private System.Windows.Forms.BindingSource pozycjaBindingSource;
        private LicencjeDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Label label1;
    }
}

