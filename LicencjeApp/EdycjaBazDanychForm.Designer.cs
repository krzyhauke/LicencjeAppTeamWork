namespace LicencjeApp
{
    partial class EdycjaBazDanychForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdycjaBazDanychForm));
            this.EdycjaBazyTabControl = new System.Windows.Forms.TabControl();
            this.ProgramyTabPage = new System.Windows.Forms.TabPage();
            this.DodajFirmeButton = new System.Windows.Forms.Button();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.TelefonFirmyLabel = new System.Windows.Forms.Label();
            this.EmailFirmyTextBox = new System.Windows.Forms.TextBox();
            this.EmailFirmyLabel = new System.Windows.Forms.Label();
            this.MiejscowoscFirmyTextBox = new System.Windows.Forms.TextBox();
            this.MiejscowoscFirmyLabel = new System.Windows.Forms.Label();
            this.AdresFirmyTextBox = new System.Windows.Forms.TextBox();
            this.AdresFirmyLabel = new System.Windows.Forms.Label();
            this.NipFirmyTextBox = new System.Windows.Forms.TextBox();
            this.NipFirmyLabel = new System.Windows.Forms.Label();
            this.NazwaFirmyTextBox = new System.Windows.Forms.TextBox();
            this.NazwaFirmyLabel = new System.Windows.Forms.Label();
            this.ProgramTabPage = new System.Windows.Forms.TabPage();
            this.NazwaProgramyTextBox = new System.Windows.Forms.TextBox();
            this.NazwaProgramuLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ModulyTabPage = new System.Windows.Forms.TabPage();
            this.KodModulyTextBox = new System.Windows.Forms.TextBox();
            this.KodModulyLabel = new System.Windows.Forms.Label();
            this.NazwaModulyTextBox = new System.Windows.Forms.TextBox();
            this.NazwaModulyLabel = new System.Windows.Forms.Label();
            this.ProgramModulyLabel = new System.Windows.Forms.Label();
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.tableAdapterManager = new LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager();
            this.programBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.programBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.EdycjaBazyTabControl.SuspendLayout();
            this.ProgramyTabPage.SuspendLayout();
            this.ProgramTabPage.SuspendLayout();
            this.ModulyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingNavigator)).BeginInit();
            this.programBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // EdycjaBazyTabControl
            // 
            this.EdycjaBazyTabControl.Controls.Add(this.ProgramyTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.ProgramTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.ModulyTabPage);
            this.EdycjaBazyTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdycjaBazyTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdycjaBazyTabControl.Location = new System.Drawing.Point(0, 0);
            this.EdycjaBazyTabControl.Name = "EdycjaBazyTabControl";
            this.EdycjaBazyTabControl.SelectedIndex = 0;
            this.EdycjaBazyTabControl.Size = new System.Drawing.Size(426, 390);
            this.EdycjaBazyTabControl.TabIndex = 0;
            // 
            // ProgramyTabPage
            // 
            this.ProgramyTabPage.Controls.Add(this.DodajFirmeButton);
            this.ProgramyTabPage.Controls.Add(this.telefonTextBox);
            this.ProgramyTabPage.Controls.Add(this.TelefonFirmyLabel);
            this.ProgramyTabPage.Controls.Add(this.EmailFirmyTextBox);
            this.ProgramyTabPage.Controls.Add(this.EmailFirmyLabel);
            this.ProgramyTabPage.Controls.Add(this.MiejscowoscFirmyTextBox);
            this.ProgramyTabPage.Controls.Add(this.MiejscowoscFirmyLabel);
            this.ProgramyTabPage.Controls.Add(this.AdresFirmyTextBox);
            this.ProgramyTabPage.Controls.Add(this.AdresFirmyLabel);
            this.ProgramyTabPage.Controls.Add(this.NipFirmyTextBox);
            this.ProgramyTabPage.Controls.Add(this.NipFirmyLabel);
            this.ProgramyTabPage.Controls.Add(this.NazwaFirmyTextBox);
            this.ProgramyTabPage.Controls.Add(this.NazwaFirmyLabel);
            this.ProgramyTabPage.Location = new System.Drawing.Point(4, 25);
            this.ProgramyTabPage.Name = "ProgramyTabPage";
            this.ProgramyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramyTabPage.Size = new System.Drawing.Size(418, 361);
            this.ProgramyTabPage.TabIndex = 0;
            this.ProgramyTabPage.Text = "Firmy";
            this.ProgramyTabPage.UseVisualStyleBackColor = true;
            // 
            // DodajFirmeButton
            // 
            this.DodajFirmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajFirmeButton.Location = new System.Drawing.Point(327, 323);
            this.DodajFirmeButton.Name = "DodajFirmeButton";
            this.DodajFirmeButton.Size = new System.Drawing.Size(83, 30);
            this.DodajFirmeButton.TabIndex = 12;
            this.DodajFirmeButton.Text = "Dodaj";
            this.DodajFirmeButton.UseVisualStyleBackColor = true;
            this.DodajFirmeButton.Click += new System.EventHandler(this.DodajFirmeButton_Click);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonTextBox.Location = new System.Drawing.Point(113, 177);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(162, 24);
            this.telefonTextBox.TabIndex = 11;
            // 
            // TelefonFirmyLabel
            // 
            this.TelefonFirmyLabel.AutoSize = true;
            this.TelefonFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TelefonFirmyLabel.Location = new System.Drawing.Point(6, 183);
            this.TelefonFirmyLabel.Name = "TelefonFirmyLabel";
            this.TelefonFirmyLabel.Size = new System.Drawing.Size(57, 18);
            this.TelefonFirmyLabel.TabIndex = 10;
            this.TelefonFirmyLabel.Text = "Telefon";
            // 
            // EmailFirmyTextBox
            // 
            this.EmailFirmyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailFirmyTextBox.Location = new System.Drawing.Point(113, 147);
            this.EmailFirmyTextBox.Name = "EmailFirmyTextBox";
            this.EmailFirmyTextBox.Size = new System.Drawing.Size(162, 24);
            this.EmailFirmyTextBox.TabIndex = 9;
            // 
            // EmailFirmyLabel
            // 
            this.EmailFirmyLabel.AutoSize = true;
            this.EmailFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailFirmyLabel.Location = new System.Drawing.Point(6, 153);
            this.EmailFirmyLabel.Name = "EmailFirmyLabel";
            this.EmailFirmyLabel.Size = new System.Drawing.Size(50, 18);
            this.EmailFirmyLabel.TabIndex = 8;
            this.EmailFirmyLabel.Text = "E-mail";
            // 
            // MiejscowoscFirmyTextBox
            // 
            this.MiejscowoscFirmyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MiejscowoscFirmyTextBox.Location = new System.Drawing.Point(113, 117);
            this.MiejscowoscFirmyTextBox.Name = "MiejscowoscFirmyTextBox";
            this.MiejscowoscFirmyTextBox.Size = new System.Drawing.Size(162, 24);
            this.MiejscowoscFirmyTextBox.TabIndex = 7;
            // 
            // MiejscowoscFirmyLabel
            // 
            this.MiejscowoscFirmyLabel.AutoSize = true;
            this.MiejscowoscFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MiejscowoscFirmyLabel.Location = new System.Drawing.Point(6, 123);
            this.MiejscowoscFirmyLabel.Name = "MiejscowoscFirmyLabel";
            this.MiejscowoscFirmyLabel.Size = new System.Drawing.Size(96, 18);
            this.MiejscowoscFirmyLabel.TabIndex = 6;
            this.MiejscowoscFirmyLabel.Text = "Miejscowość";
            // 
            // AdresFirmyTextBox
            // 
            this.AdresFirmyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdresFirmyTextBox.Location = new System.Drawing.Point(113, 87);
            this.AdresFirmyTextBox.Name = "AdresFirmyTextBox";
            this.AdresFirmyTextBox.Size = new System.Drawing.Size(162, 24);
            this.AdresFirmyTextBox.TabIndex = 5;
            // 
            // AdresFirmyLabel
            // 
            this.AdresFirmyLabel.AutoSize = true;
            this.AdresFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdresFirmyLabel.Location = new System.Drawing.Point(6, 93);
            this.AdresFirmyLabel.Name = "AdresFirmyLabel";
            this.AdresFirmyLabel.Size = new System.Drawing.Size(46, 18);
            this.AdresFirmyLabel.TabIndex = 4;
            this.AdresFirmyLabel.Text = "Adres";
            // 
            // NipFirmyTextBox
            // 
            this.NipFirmyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NipFirmyTextBox.Location = new System.Drawing.Point(113, 57);
            this.NipFirmyTextBox.Name = "NipFirmyTextBox";
            this.NipFirmyTextBox.Size = new System.Drawing.Size(162, 24);
            this.NipFirmyTextBox.TabIndex = 3;
            // 
            // NipFirmyLabel
            // 
            this.NipFirmyLabel.AutoSize = true;
            this.NipFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NipFirmyLabel.Location = new System.Drawing.Point(6, 63);
            this.NipFirmyLabel.Name = "NipFirmyLabel";
            this.NipFirmyLabel.Size = new System.Drawing.Size(32, 18);
            this.NipFirmyLabel.TabIndex = 2;
            this.NipFirmyLabel.Text = "NIP";
            // 
            // NazwaFirmyTextBox
            // 
            this.NazwaFirmyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaFirmyTextBox.Location = new System.Drawing.Point(113, 27);
            this.NazwaFirmyTextBox.Name = "NazwaFirmyTextBox";
            this.NazwaFirmyTextBox.Size = new System.Drawing.Size(162, 24);
            this.NazwaFirmyTextBox.TabIndex = 1;
            // 
            // NazwaFirmyLabel
            // 
            this.NazwaFirmyLabel.AutoSize = true;
            this.NazwaFirmyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaFirmyLabel.Location = new System.Drawing.Point(6, 33);
            this.NazwaFirmyLabel.Name = "NazwaFirmyLabel";
            this.NazwaFirmyLabel.Size = new System.Drawing.Size(95, 18);
            this.NazwaFirmyLabel.TabIndex = 0;
            this.NazwaFirmyLabel.Text = "Nazwa Firmy";
            // 
            // ProgramTabPage
            // 
            this.ProgramTabPage.Controls.Add(this.button1);
            this.ProgramTabPage.Controls.Add(this.NazwaProgramyTextBox);
            this.ProgramTabPage.Controls.Add(this.NazwaProgramuLabel);
            this.ProgramTabPage.Location = new System.Drawing.Point(4, 25);
            this.ProgramTabPage.Name = "ProgramTabPage";
            this.ProgramTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProgramTabPage.Size = new System.Drawing.Size(418, 361);
            this.ProgramTabPage.TabIndex = 1;
            this.ProgramTabPage.Text = "Programy";
            this.ProgramTabPage.UseVisualStyleBackColor = true;
            // 
            // NazwaProgramyTextBox
            // 
            this.NazwaProgramyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaProgramyTextBox.Location = new System.Drawing.Point(136, 27);
            this.NazwaProgramyTextBox.Name = "NazwaProgramyTextBox";
            this.NazwaProgramyTextBox.Size = new System.Drawing.Size(162, 24);
            this.NazwaProgramyTextBox.TabIndex = 3;
            // 
            // NazwaProgramuLabel
            // 
            this.NazwaProgramuLabel.AutoSize = true;
            this.NazwaProgramuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaProgramuLabel.Location = new System.Drawing.Point(6, 33);
            this.NazwaProgramuLabel.Name = "NazwaProgramuLabel";
            this.NazwaProgramuLabel.Size = new System.Drawing.Size(124, 18);
            this.NazwaProgramuLabel.TabIndex = 2;
            this.NazwaProgramuLabel.Text = "Nazwa Programu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(327, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ModulyTabPage
            // 
            this.ModulyTabPage.AutoScroll = true;
            this.ModulyTabPage.Controls.Add(this.programComboBox);
            this.ModulyTabPage.Controls.Add(this.ProgramModulyLabel);
            this.ModulyTabPage.Controls.Add(this.KodModulyTextBox);
            this.ModulyTabPage.Controls.Add(this.KodModulyLabel);
            this.ModulyTabPage.Controls.Add(this.NazwaModulyTextBox);
            this.ModulyTabPage.Controls.Add(this.NazwaModulyLabel);
            this.ModulyTabPage.Location = new System.Drawing.Point(4, 25);
            this.ModulyTabPage.Name = "ModulyTabPage";
            this.ModulyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModulyTabPage.Size = new System.Drawing.Size(418, 361);
            this.ModulyTabPage.TabIndex = 2;
            this.ModulyTabPage.Text = "Moduły";
            this.ModulyTabPage.UseVisualStyleBackColor = true;
            // 
            // KodModulyTextBox
            // 
            this.KodModulyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodModulyTextBox.Location = new System.Drawing.Point(119, 57);
            this.KodModulyTextBox.Name = "KodModulyTextBox";
            this.KodModulyTextBox.Size = new System.Drawing.Size(162, 24);
            this.KodModulyTextBox.TabIndex = 7;
            // 
            // KodModulyLabel
            // 
            this.KodModulyLabel.AutoSize = true;
            this.KodModulyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodModulyLabel.Location = new System.Drawing.Point(6, 63);
            this.KodModulyLabel.Name = "KodModulyLabel";
            this.KodModulyLabel.Size = new System.Drawing.Size(41, 18);
            this.KodModulyLabel.TabIndex = 6;
            this.KodModulyLabel.Text = "KOD";
            // 
            // NazwaModulyTextBox
            // 
            this.NazwaModulyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaModulyTextBox.Location = new System.Drawing.Point(119, 27);
            this.NazwaModulyTextBox.Name = "NazwaModulyTextBox";
            this.NazwaModulyTextBox.Size = new System.Drawing.Size(162, 24);
            this.NazwaModulyTextBox.TabIndex = 5;
            // 
            // NazwaModulyLabel
            // 
            this.NazwaModulyLabel.AutoSize = true;
            this.NazwaModulyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaModulyLabel.Location = new System.Drawing.Point(6, 33);
            this.NazwaModulyLabel.Name = "NazwaModulyLabel";
            this.NazwaModulyLabel.Size = new System.Drawing.Size(107, 18);
            this.NazwaModulyLabel.TabIndex = 4;
            this.NazwaModulyLabel.Text = "Nazwa Modułu";
            // 
            // ProgramModulyLabel
            // 
            this.ProgramModulyLabel.AutoSize = true;
            this.ProgramModulyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgramModulyLabel.Location = new System.Drawing.Point(3, 95);
            this.ProgramModulyLabel.Name = "ProgramModulyLabel";
            this.ProgramModulyLabel.Size = new System.Drawing.Size(70, 18);
            this.ProgramModulyLabel.TabIndex = 8;
            this.ProgramModulyLabel.Text = "Program ";
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
            // programTableAdapter
            // 
            this.programTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmyTableAdapter = null;
            this.tableAdapterManager.LicencjaTableAdapter = null;
            this.tableAdapterManager.ModulyTableAdapter = null;
            this.tableAdapterManager.PozycjaTableAdapter = null;
            this.tableAdapterManager.ProgramTableAdapter = this.programTableAdapter;
            this.tableAdapterManager.UpdateOrder = LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // programBindingNavigator
            // 
            this.programBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programBindingNavigator.BindingSource = this.programBindingSource;
            this.programBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.programBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.programBindingNavigatorSaveItem});
            this.programBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.programBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programBindingNavigator.Name = "programBindingNavigator";
            this.programBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programBindingNavigator.Size = new System.Drawing.Size(426, 25);
            this.programBindingNavigator.TabIndex = 1;
            this.programBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // programBindingNavigatorSaveItem
            // 
            this.programBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.programBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programBindingNavigatorSaveItem.Image")));
            this.programBindingNavigatorSaveItem.Name = "programBindingNavigatorSaveItem";
            this.programBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.programBindingNavigatorSaveItem.Text = "Save Data";
            this.programBindingNavigatorSaveItem.Click += new System.EventHandler(this.programBindingNavigatorSaveItem_Click);
            // 
            // programComboBox
            // 
            this.programComboBox.DataSource = this.programBindingSource;
            this.programComboBox.DisplayMember = "Nazwa";
            this.programComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(119, 87);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(162, 26);
            this.programComboBox.TabIndex = 8;
            this.programComboBox.ValueMember = "ID";
            // 
            // EdycjaBazDanychForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 390);
            this.Controls.Add(this.programBindingNavigator);
            this.Controls.Add(this.EdycjaBazyTabControl);
            this.Name = "EdycjaBazDanychForm";
            this.Text = "Dodaj dane do bazy danych";
            this.Load += new System.EventHandler(this.EdycjaBazDanychForm_Load);
            this.EdycjaBazyTabControl.ResumeLayout(false);
            this.ProgramyTabPage.ResumeLayout(false);
            this.ProgramyTabPage.PerformLayout();
            this.ProgramTabPage.ResumeLayout(false);
            this.ProgramTabPage.PerformLayout();
            this.ModulyTabPage.ResumeLayout(false);
            this.ModulyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingNavigator)).EndInit();
            this.programBindingNavigator.ResumeLayout(false);
            this.programBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl EdycjaBazyTabControl;
        private System.Windows.Forms.TabPage ProgramyTabPage;
        private System.Windows.Forms.TabPage ProgramTabPage;
        private System.Windows.Forms.TextBox NazwaFirmyTextBox;
        private System.Windows.Forms.Label NazwaFirmyLabel;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label TelefonFirmyLabel;
        private System.Windows.Forms.TextBox EmailFirmyTextBox;
        private System.Windows.Forms.Label EmailFirmyLabel;
        private System.Windows.Forms.TextBox MiejscowoscFirmyTextBox;
        private System.Windows.Forms.Label MiejscowoscFirmyLabel;
        private System.Windows.Forms.TextBox AdresFirmyTextBox;
        private System.Windows.Forms.Label AdresFirmyLabel;
        private System.Windows.Forms.TextBox NipFirmyTextBox;
        private System.Windows.Forms.Label NipFirmyLabel;
        private System.Windows.Forms.Button DodajFirmeButton;
        private System.Windows.Forms.TextBox NazwaProgramyTextBox;
        private System.Windows.Forms.Label NazwaProgramuLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage ModulyTabPage;
        private System.Windows.Forms.TextBox KodModulyTextBox;
        private System.Windows.Forms.Label KodModulyLabel;
        private System.Windows.Forms.TextBox NazwaModulyTextBox;
        private System.Windows.Forms.Label NazwaModulyLabel;
        private System.Windows.Forms.Label ProgramModulyLabel;
        private LicencjeDataSet licencjeDataSet;
        private System.Windows.Forms.BindingSource programBindingSource;
        private LicencjeDataSetTableAdapters.ProgramTableAdapter programTableAdapter;
        private LicencjeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator programBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox programComboBox;
    }
}