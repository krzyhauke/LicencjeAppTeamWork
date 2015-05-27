namespace LicencjeApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.firmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.FirmyTableAdapter();
            this.tableAdapterManager = new LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager();
            this.licencjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.LicencjaTableAdapter();
            this.modulyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ModulyTableAdapter();
            this.pozycjaTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.PozycjaTableAdapter();
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.PasekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.RefreshStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.firmyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.UstawieniaToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.edycjaBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WybierzBazeDanychToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.firmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modułyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licencjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozycjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabelaDataGridView = new System.Windows.Forms.DataGridView();
            this.licencjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pozycjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasekBindingNavigator)).BeginInit();
            this.PasekBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGridView)).BeginInit();
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
            // PasekBindingNavigator
            // 
            this.PasekBindingNavigator.AddNewItem = null;
            this.PasekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PasekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.PasekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.RefreshStripButton1,
            this.firmyBindingNavigatorSaveItem,
            this.UstawieniaToolStripDropDownButton,
            this.WybierzBazeDanychToolStripDropDownButton});
            this.PasekBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.PasekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PasekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PasekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PasekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PasekBindingNavigator.Name = "PasekBindingNavigator";
            this.PasekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PasekBindingNavigator.Size = new System.Drawing.Size(746, 25);
            this.PasekBindingNavigator.TabIndex = 0;
            this.PasekBindingNavigator.Text = "Witam Serdecznie";
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
            // RefreshStripButton1
            // 
            this.RefreshStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshStripButton1.Image = global::LicencjeApp.Properties.Resources.Refresh_icon;
            this.RefreshStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshStripButton1.Name = "RefreshStripButton1";
            this.RefreshStripButton1.Size = new System.Drawing.Size(23, 22);
            this.RefreshStripButton1.Text = "Odśwież ";
            this.RefreshStripButton1.Click += new System.EventHandler(this.RefreshStripButton1_Click);
            // 
            // firmyBindingNavigatorSaveItem
            // 
            this.firmyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firmyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("firmyBindingNavigatorSaveItem.Image")));
            this.firmyBindingNavigatorSaveItem.Name = "firmyBindingNavigatorSaveItem";
            this.firmyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.firmyBindingNavigatorSaveItem.Text = "Zapisz";
            this.firmyBindingNavigatorSaveItem.Click += new System.EventHandler(this.firmyBindingNavigatorSaveItem_Click);
            // 
            // UstawieniaToolStripDropDownButton
            // 
            this.UstawieniaToolStripDropDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UstawieniaToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edycjaBazyDanychToolStripMenuItem});
            this.UstawieniaToolStripDropDownButton.Image = global::LicencjeApp.Properties.Resources._7b9752c8_02b8_4311_b065_e194f3046e27;
            this.UstawieniaToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UstawieniaToolStripDropDownButton.Name = "UstawieniaToolStripDropDownButton";
            this.UstawieniaToolStripDropDownButton.Size = new System.Drawing.Size(93, 22);
            this.UstawieniaToolStripDropDownButton.Text = "Ustawienia";
            // 
            // edycjaBazyDanychToolStripMenuItem
            // 
            this.edycjaBazyDanychToolStripMenuItem.Name = "edycjaBazyDanychToolStripMenuItem";
            this.edycjaBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.edycjaBazyDanychToolStripMenuItem.Text = "Edycja Bazy Danych";
            this.edycjaBazyDanychToolStripMenuItem.Click += new System.EventHandler(this.edycjaBazyDanychToolStripMenuItem_Click);
            // 
            // WybierzBazeDanychToolStripDropDownButton
            // 
            this.WybierzBazeDanychToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WybierzBazeDanychToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmyToolStripMenuItem,
            this.programyToolStripMenuItem,
            this.modułyToolStripMenuItem,
            this.licencjeToolStripMenuItem,
            this.pozycjeToolStripMenuItem});
            this.WybierzBazeDanychToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("WybierzBazeDanychToolStripDropDownButton.Image")));
            this.WybierzBazeDanychToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WybierzBazeDanychToolStripDropDownButton.Name = "WybierzBazeDanychToolStripDropDownButton";
            this.WybierzBazeDanychToolStripDropDownButton.Size = new System.Drawing.Size(122, 22);
            this.WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Firma";
            // 
            // firmyToolStripMenuItem
            // 
            this.firmyToolStripMenuItem.Name = "firmyToolStripMenuItem";
            this.firmyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.firmyToolStripMenuItem.Text = "Firmy";
            this.firmyToolStripMenuItem.Click += new System.EventHandler(this.firmyToolStripMenuItem_Click);
            // 
            // programyToolStripMenuItem
            // 
            this.programyToolStripMenuItem.Name = "programyToolStripMenuItem";
            this.programyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.programyToolStripMenuItem.Text = "Programy";
            this.programyToolStripMenuItem.Click += new System.EventHandler(this.programyToolStripMenuItem_Click);
            // 
            // modułyToolStripMenuItem
            // 
            this.modułyToolStripMenuItem.Name = "modułyToolStripMenuItem";
            this.modułyToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.modułyToolStripMenuItem.Text = "Moduły";
            this.modułyToolStripMenuItem.Click += new System.EventHandler(this.modułyToolStripMenuItem_Click);
            // 
            // licencjeToolStripMenuItem
            // 
            this.licencjeToolStripMenuItem.Name = "licencjeToolStripMenuItem";
            this.licencjeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.licencjeToolStripMenuItem.Text = "Licencje";
            this.licencjeToolStripMenuItem.Click += new System.EventHandler(this.licencjeToolStripMenuItem_Click);
            // 
            // pozycjeToolStripMenuItem
            // 
            this.pozycjeToolStripMenuItem.Name = "pozycjeToolStripMenuItem";
            this.pozycjeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.pozycjeToolStripMenuItem.Text = "Pozycje";
            this.pozycjeToolStripMenuItem.Click += new System.EventHandler(this.pozycjeToolStripMenuItem_Click);
            // 
            // TabelaDataGridView
            // 
            this.TabelaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabelaDataGridView.Location = new System.Drawing.Point(0, 25);
            this.TabelaDataGridView.Name = "TabelaDataGridView";
            this.TabelaDataGridView.Size = new System.Drawing.Size(746, 510);
            this.TabelaDataGridView.TabIndex = 1;
            this.TabelaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaDataGridView_CellDoubleClick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 535);
            this.Controls.Add(this.TabelaDataGridView);
            this.Controls.Add(this.PasekBindingNavigator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasekBindingNavigator)).EndInit();
            this.PasekBindingNavigator.ResumeLayout(false);
            this.PasekBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingNavigator PasekBindingNavigator;
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
        private System.Windows.Forms.DataGridView TabelaDataGridView;
        private LicencjeDataSetTableAdapters.LicencjaTableAdapter licencjaTableAdapter;
        private System.Windows.Forms.BindingSource licencjaBindingSource;
        private LicencjeDataSetTableAdapters.ModulyTableAdapter modulyTableAdapter;
        private System.Windows.Forms.BindingSource modulyBindingSource;
        private LicencjeDataSetTableAdapters.PozycjaTableAdapter pozycjaTableAdapter;
        private System.Windows.Forms.BindingSource pozycjaBindingSource;
        private LicencjeDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.ToolStripDropDownButton UstawieniaToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem edycjaBazyDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton WybierzBazeDanychToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem firmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modułyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licencjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozycjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton RefreshStripButton1;
    }
}

