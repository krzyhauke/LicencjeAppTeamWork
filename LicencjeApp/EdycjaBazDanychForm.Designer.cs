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
            this.DodajProgramButton = new System.Windows.Forms.Button();
            this.NazwaProgramyTextBox = new System.Windows.Forms.TextBox();
            this.NazwaProgramuLabel = new System.Windows.Forms.Label();
            this.ModulyTabPage = new System.Windows.Forms.TabPage();
            this.DodajModulButton = new System.Windows.Forms.Button();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licencjeDataSet = new LicencjeApp.LicencjeDataSet();
            this.ProgramModulyLabel = new System.Windows.Forms.Label();
            this.KodModulyTextBox = new System.Windows.Forms.TextBox();
            this.KodModulyLabel = new System.Windows.Forms.Label();
            this.NazwaModulyTextBox = new System.Windows.Forms.TextBox();
            this.NazwaModulyLabel = new System.Windows.Forms.Label();
            this.LicencjeTabPage = new System.Windows.Forms.TabPage();
            this.NumerLicencjiTextBox = new System.Windows.Forms.TextBox();
            this.NumerLicencjiLabel = new System.Windows.Forms.Label();
            this.NazwaFirmyLicencjeLabel = new System.Windows.Forms.Label();
            this.programTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ProgramTableAdapter();
            this.tableAdapterManager = new LicencjeApp.LicencjeDataSetTableAdapters.TableAdapterManager();
            this.DataDoLabel = new System.Windows.Forms.Label();
            this.DataOdLabel = new System.Windows.Forms.Label();
            this.DataOddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataDodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProgramLicencjeLabel = new System.Windows.Forms.Label();
            this.IloscLicencjeLabel = new System.Windows.Forms.Label();
            this.CenaLicencjeLabel = new System.Windows.Forms.Label();
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programComboBox1 = new System.Windows.Forms.ComboBox();
            this.IloscLicencjinumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CenaLicencjinumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.PozycjetabPage = new System.Windows.Forms.TabPage();
            this.firmyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.FirmyTableAdapter();
            this.firmyLicencjeComboBox = new System.Windows.Forms.ComboBox();
            this.ModulPozycjaLabel = new System.Windows.Forms.Label();
            this.FirmaPozycjeLabel = new System.Windows.Forms.Label();
            this.modulyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulyTableAdapter = new LicencjeApp.LicencjeDataSetTableAdapters.ModulyTableAdapter();
            this.modulyComboBox = new System.Windows.Forms.ComboBox();
            this.firmyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firmyPozycjeComboBox1 = new System.Windows.Forms.ComboBox();
            this.DodajLicencjeButton = new System.Windows.Forms.Button();
            this.DodajPozycjeButton = new System.Windows.Forms.Button();
            this.EdycjaBazyTabControl.SuspendLayout();
            this.ProgramyTabPage.SuspendLayout();
            this.ProgramTabPage.SuspendLayout();
            this.ModulyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).BeginInit();
            this.LicencjeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IloscLicencjinumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaLicencjinumericUpDown2)).BeginInit();
            this.PozycjetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EdycjaBazyTabControl
            // 
            this.EdycjaBazyTabControl.Controls.Add(this.ProgramyTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.ProgramTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.ModulyTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.LicencjeTabPage);
            this.EdycjaBazyTabControl.Controls.Add(this.PozycjetabPage);
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
            this.ProgramTabPage.Controls.Add(this.DodajProgramButton);
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
            // DodajProgramButton
            // 
            this.DodajProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajProgramButton.Location = new System.Drawing.Point(327, 323);
            this.DodajProgramButton.Name = "DodajProgramButton";
            this.DodajProgramButton.Size = new System.Drawing.Size(83, 30);
            this.DodajProgramButton.TabIndex = 13;
            this.DodajProgramButton.Text = "Dodaj";
            this.DodajProgramButton.UseVisualStyleBackColor = true;
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
            // ModulyTabPage
            // 
            this.ModulyTabPage.AutoScroll = true;
            this.ModulyTabPage.Controls.Add(this.DodajModulButton);
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
            // DodajModulButton
            // 
            this.DodajModulButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajModulButton.Location = new System.Drawing.Point(327, 323);
            this.DodajModulButton.Name = "DodajModulButton";
            this.DodajModulButton.Size = new System.Drawing.Size(83, 30);
            this.DodajModulButton.TabIndex = 14;
            this.DodajModulButton.Text = "Dodaj";
            this.DodajModulButton.UseVisualStyleBackColor = true;
            // 
            // programComboBox
            // 
            this.programComboBox.DataSource = this.programBindingSource;
            this.programComboBox.DisplayMember = "Nazwa";
            this.programComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(119, 87);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(214, 26);
            this.programComboBox.TabIndex = 8;
            this.programComboBox.ValueMember = "ID";
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
            // KodModulyTextBox
            // 
            this.KodModulyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodModulyTextBox.Location = new System.Drawing.Point(119, 57);
            this.KodModulyTextBox.Name = "KodModulyTextBox";
            this.KodModulyTextBox.Size = new System.Drawing.Size(214, 24);
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
            this.NazwaModulyTextBox.Size = new System.Drawing.Size(214, 24);
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
            // LicencjeTabPage
            // 
            this.LicencjeTabPage.AutoScroll = true;
            this.LicencjeTabPage.Controls.Add(this.DodajLicencjeButton);
            this.LicencjeTabPage.Controls.Add(this.firmyLicencjeComboBox);
            this.LicencjeTabPage.Controls.Add(this.CenaLicencjinumericUpDown2);
            this.LicencjeTabPage.Controls.Add(this.IloscLicencjinumericUpDown);
            this.LicencjeTabPage.Controls.Add(this.programComboBox1);
            this.LicencjeTabPage.Controls.Add(this.CenaLicencjeLabel);
            this.LicencjeTabPage.Controls.Add(this.ProgramLicencjeLabel);
            this.LicencjeTabPage.Controls.Add(this.IloscLicencjeLabel);
            this.LicencjeTabPage.Controls.Add(this.DataDodateTimePicker);
            this.LicencjeTabPage.Controls.Add(this.DataOddateTimePicker);
            this.LicencjeTabPage.Controls.Add(this.DataOdLabel);
            this.LicencjeTabPage.Controls.Add(this.DataDoLabel);
            this.LicencjeTabPage.Controls.Add(this.NumerLicencjiTextBox);
            this.LicencjeTabPage.Controls.Add(this.NumerLicencjiLabel);
            this.LicencjeTabPage.Controls.Add(this.NazwaFirmyLicencjeLabel);
            this.LicencjeTabPage.Location = new System.Drawing.Point(4, 25);
            this.LicencjeTabPage.Name = "LicencjeTabPage";
            this.LicencjeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LicencjeTabPage.Size = new System.Drawing.Size(418, 361);
            this.LicencjeTabPage.TabIndex = 3;
            this.LicencjeTabPage.Text = "Licencje";
            this.LicencjeTabPage.UseVisualStyleBackColor = true;
            // 
            // NumerLicencjiTextBox
            // 
            this.NumerLicencjiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerLicencjiTextBox.Location = new System.Drawing.Point(118, 57);
            this.NumerLicencjiTextBox.Name = "NumerLicencjiTextBox";
            this.NumerLicencjiTextBox.Size = new System.Drawing.Size(200, 24);
            this.NumerLicencjiTextBox.TabIndex = 3;
            // 
            // NumerLicencjiLabel
            // 
            this.NumerLicencjiLabel.AutoSize = true;
            this.NumerLicencjiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerLicencjiLabel.Location = new System.Drawing.Point(6, 63);
            this.NumerLicencjiLabel.Name = "NumerLicencjiLabel";
            this.NumerLicencjiLabel.Size = new System.Drawing.Size(106, 18);
            this.NumerLicencjiLabel.TabIndex = 2;
            this.NumerLicencjiLabel.Text = "Numer Licencji";
            // 
            // NazwaFirmyLicencjeLabel
            // 
            this.NazwaFirmyLicencjeLabel.AutoSize = true;
            this.NazwaFirmyLicencjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaFirmyLicencjeLabel.Location = new System.Drawing.Point(6, 33);
            this.NazwaFirmyLicencjeLabel.Name = "NazwaFirmyLicencjeLabel";
            this.NazwaFirmyLicencjeLabel.Size = new System.Drawing.Size(46, 18);
            this.NazwaFirmyLicencjeLabel.TabIndex = 1;
            this.NazwaFirmyLicencjeLabel.Text = "Firma";
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
            // DataDoLabel
            // 
            this.DataDoLabel.AutoSize = true;
            this.DataDoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataDoLabel.Location = new System.Drawing.Point(6, 119);
            this.DataDoLabel.Name = "DataDoLabel";
            this.DataDoLabel.Size = new System.Drawing.Size(64, 18);
            this.DataDoLabel.TabIndex = 4;
            this.DataDoLabel.Text = "Data do:";
            // 
            // DataOdLabel
            // 
            this.DataOdLabel.AutoSize = true;
            this.DataOdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DataOdLabel.Location = new System.Drawing.Point(6, 91);
            this.DataOdLabel.Name = "DataOdLabel";
            this.DataOdLabel.Size = new System.Drawing.Size(64, 18);
            this.DataOdLabel.TabIndex = 5;
            this.DataOdLabel.Text = "Data od:";
            // 
            // DataOddateTimePicker
            // 
            this.DataOddateTimePicker.Location = new System.Drawing.Point(118, 87);
            this.DataOddateTimePicker.Name = "DataOddateTimePicker";
            this.DataOddateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DataOddateTimePicker.TabIndex = 6;
            // 
            // DataDodateTimePicker
            // 
            this.DataDodateTimePicker.Location = new System.Drawing.Point(118, 115);
            this.DataDodateTimePicker.Name = "DataDodateTimePicker";
            this.DataDodateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DataDodateTimePicker.TabIndex = 7;
            // 
            // ProgramLicencjeLabel
            // 
            this.ProgramLicencjeLabel.AutoSize = true;
            this.ProgramLicencjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgramLicencjeLabel.Location = new System.Drawing.Point(6, 149);
            this.ProgramLicencjeLabel.Name = "ProgramLicencjeLabel";
            this.ProgramLicencjeLabel.Size = new System.Drawing.Size(66, 18);
            this.ProgramLicencjeLabel.TabIndex = 9;
            this.ProgramLicencjeLabel.Text = "Program";
            // 
            // IloscLicencjeLabel
            // 
            this.IloscLicencjeLabel.AutoSize = true;
            this.IloscLicencjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IloscLicencjeLabel.Location = new System.Drawing.Point(6, 177);
            this.IloscLicencjeLabel.Name = "IloscLicencjeLabel";
            this.IloscLicencjeLabel.Size = new System.Drawing.Size(39, 18);
            this.IloscLicencjeLabel.TabIndex = 8;
            this.IloscLicencjeLabel.Text = "Ilość";
            // 
            // CenaLicencjeLabel
            // 
            this.CenaLicencjeLabel.AutoSize = true;
            this.CenaLicencjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CenaLicencjeLabel.Location = new System.Drawing.Point(6, 205);
            this.CenaLicencjeLabel.Name = "CenaLicencjeLabel";
            this.CenaLicencjeLabel.Size = new System.Drawing.Size(43, 18);
            this.CenaLicencjeLabel.TabIndex = 10;
            this.CenaLicencjeLabel.Text = "Cena";
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataMember = "Program";
            this.programBindingSource1.DataSource = this.licencjeDataSet;
            // 
            // programComboBox1
            // 
            this.programComboBox1.DataSource = this.programBindingSource1;
            this.programComboBox1.DisplayMember = "Nazwa";
            this.programComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox1.FormattingEnabled = true;
            this.programComboBox1.Location = new System.Drawing.Point(118, 143);
            this.programComboBox1.Name = "programComboBox1";
            this.programComboBox1.Size = new System.Drawing.Size(200, 24);
            this.programComboBox1.TabIndex = 10;
            this.programComboBox1.ValueMember = "ID";
            // 
            // IloscLicencjinumericUpDown
            // 
            this.IloscLicencjinumericUpDown.Location = new System.Drawing.Point(118, 173);
            this.IloscLicencjinumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.IloscLicencjinumericUpDown.Name = "IloscLicencjinumericUpDown";
            this.IloscLicencjinumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.IloscLicencjinumericUpDown.TabIndex = 11;
            // 
            // CenaLicencjinumericUpDown2
            // 
            this.CenaLicencjinumericUpDown2.DecimalPlaces = 2;
            this.CenaLicencjinumericUpDown2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CenaLicencjinumericUpDown2.Location = new System.Drawing.Point(118, 201);
            this.CenaLicencjinumericUpDown2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CenaLicencjinumericUpDown2.Name = "CenaLicencjinumericUpDown2";
            this.CenaLicencjinumericUpDown2.Size = new System.Drawing.Size(200, 22);
            this.CenaLicencjinumericUpDown2.TabIndex = 12;
            // 
            // PozycjetabPage
            // 
            this.PozycjetabPage.AutoScroll = true;
            this.PozycjetabPage.Controls.Add(this.DodajPozycjeButton);
            this.PozycjetabPage.Controls.Add(this.firmyPozycjeComboBox1);
            this.PozycjetabPage.Controls.Add(this.modulyComboBox);
            this.PozycjetabPage.Controls.Add(this.ModulPozycjaLabel);
            this.PozycjetabPage.Controls.Add(this.FirmaPozycjeLabel);
            this.PozycjetabPage.Location = new System.Drawing.Point(4, 25);
            this.PozycjetabPage.Name = "PozycjetabPage";
            this.PozycjetabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PozycjetabPage.Size = new System.Drawing.Size(418, 361);
            this.PozycjetabPage.TabIndex = 4;
            this.PozycjetabPage.Text = "Pozycje";
            this.PozycjetabPage.UseVisualStyleBackColor = true;
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
            // firmyLicencjeComboBox
            // 
            this.firmyLicencjeComboBox.DataSource = this.firmyBindingSource;
            this.firmyLicencjeComboBox.DisplayMember = "NAZWA";
            this.firmyLicencjeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmyLicencjeComboBox.FormattingEnabled = true;
            this.firmyLicencjeComboBox.Location = new System.Drawing.Point(118, 27);
            this.firmyLicencjeComboBox.Name = "firmyLicencjeComboBox";
            this.firmyLicencjeComboBox.Size = new System.Drawing.Size(200, 24);
            this.firmyLicencjeComboBox.TabIndex = 13;
            this.firmyLicencjeComboBox.ValueMember = "ID";
            // 
            // ModulPozycjaLabel
            // 
            this.ModulPozycjaLabel.AutoSize = true;
            this.ModulPozycjaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModulPozycjaLabel.Location = new System.Drawing.Point(3, 63);
            this.ModulPozycjaLabel.Name = "ModulPozycjaLabel";
            this.ModulPozycjaLabel.Size = new System.Drawing.Size(106, 18);
            this.ModulPozycjaLabel.TabIndex = 4;
            this.ModulPozycjaLabel.Text = "Numer Licencji";
            // 
            // FirmaPozycjeLabel
            // 
            this.FirmaPozycjeLabel.AutoSize = true;
            this.FirmaPozycjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirmaPozycjeLabel.Location = new System.Drawing.Point(6, 33);
            this.FirmaPozycjeLabel.Name = "FirmaPozycjeLabel";
            this.FirmaPozycjeLabel.Size = new System.Drawing.Size(46, 18);
            this.FirmaPozycjeLabel.TabIndex = 3;
            this.FirmaPozycjeLabel.Text = "Firma";
            // 
            // modulyBindingSource
            // 
            this.modulyBindingSource.DataMember = "Moduly";
            this.modulyBindingSource.DataSource = this.licencjeDataSet;
            // 
            // modulyTableAdapter
            // 
            this.modulyTableAdapter.ClearBeforeFill = true;
            // 
            // modulyComboBox
            // 
            this.modulyComboBox.DataSource = this.modulyBindingSource;
            this.modulyComboBox.DisplayMember = "Nazwa";
            this.modulyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modulyComboBox.FormattingEnabled = true;
            this.modulyComboBox.Location = new System.Drawing.Point(135, 57);
            this.modulyComboBox.Name = "modulyComboBox";
            this.modulyComboBox.Size = new System.Drawing.Size(218, 24);
            this.modulyComboBox.TabIndex = 4;
            this.modulyComboBox.ValueMember = "ID";
            // 
            // firmyBindingSource1
            // 
            this.firmyBindingSource1.DataMember = "Firmy";
            this.firmyBindingSource1.DataSource = this.licencjeDataSet;
            // 
            // firmyPozycjeComboBox1
            // 
            this.firmyPozycjeComboBox1.DataSource = this.firmyBindingSource1;
            this.firmyPozycjeComboBox1.DisplayMember = "NAZWA";
            this.firmyPozycjeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firmyPozycjeComboBox1.FormattingEnabled = true;
            this.firmyPozycjeComboBox1.Location = new System.Drawing.Point(135, 27);
            this.firmyPozycjeComboBox1.Name = "firmyPozycjeComboBox1";
            this.firmyPozycjeComboBox1.Size = new System.Drawing.Size(218, 24);
            this.firmyPozycjeComboBox1.TabIndex = 4;
            this.firmyPozycjeComboBox1.ValueMember = "ID";
            // 
            // DodajLicencjeButton
            // 
            this.DodajLicencjeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajLicencjeButton.Location = new System.Drawing.Point(327, 323);
            this.DodajLicencjeButton.Name = "DodajLicencjeButton";
            this.DodajLicencjeButton.Size = new System.Drawing.Size(83, 30);
            this.DodajLicencjeButton.TabIndex = 14;
            this.DodajLicencjeButton.Text = "Dodaj";
            this.DodajLicencjeButton.UseVisualStyleBackColor = true;
            // 
            // DodajPozycjeButton
            // 
            this.DodajPozycjeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajPozycjeButton.Location = new System.Drawing.Point(327, 323);
            this.DodajPozycjeButton.Name = "DodajPozycjeButton";
            this.DodajPozycjeButton.Size = new System.Drawing.Size(83, 30);
            this.DodajPozycjeButton.TabIndex = 13;
            this.DodajPozycjeButton.Text = "Dodaj";
            this.DodajPozycjeButton.UseVisualStyleBackColor = true;
            // 
            // EdycjaBazDanychForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 390);
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
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencjeDataSet)).EndInit();
            this.LicencjeTabPage.ResumeLayout(false);
            this.LicencjeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IloscLicencjinumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenaLicencjinumericUpDown2)).EndInit();
            this.PozycjetabPage.ResumeLayout(false);
            this.PozycjetabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmyBindingSource1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button DodajProgramButton;
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
        private System.Windows.Forms.ComboBox programComboBox;
        private System.Windows.Forms.Button DodajModulButton;
        private System.Windows.Forms.TabPage LicencjeTabPage;
        private System.Windows.Forms.TextBox NumerLicencjiTextBox;
        private System.Windows.Forms.Label NumerLicencjiLabel;
        private System.Windows.Forms.Label NazwaFirmyLicencjeLabel;
        private System.Windows.Forms.Label ProgramLicencjeLabel;
        private System.Windows.Forms.Label IloscLicencjeLabel;
        private System.Windows.Forms.DateTimePicker DataDodateTimePicker;
        private System.Windows.Forms.DateTimePicker DataOddateTimePicker;
        private System.Windows.Forms.Label DataOdLabel;
        private System.Windows.Forms.Label DataDoLabel;
        private System.Windows.Forms.Label CenaLicencjeLabel;
        private System.Windows.Forms.ComboBox programComboBox1;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.NumericUpDown CenaLicencjinumericUpDown2;
        private System.Windows.Forms.NumericUpDown IloscLicencjinumericUpDown;
        private System.Windows.Forms.TabPage PozycjetabPage;
        private System.Windows.Forms.BindingSource firmyBindingSource;
        private LicencjeDataSetTableAdapters.FirmyTableAdapter firmyTableAdapter;
        private System.Windows.Forms.ComboBox firmyLicencjeComboBox;
        private System.Windows.Forms.Label ModulPozycjaLabel;
        private System.Windows.Forms.Label FirmaPozycjeLabel;
        private System.Windows.Forms.BindingSource modulyBindingSource;
        private LicencjeDataSetTableAdapters.ModulyTableAdapter modulyTableAdapter;
        private System.Windows.Forms.ComboBox firmyPozycjeComboBox1;
        private System.Windows.Forms.BindingSource firmyBindingSource1;
        private System.Windows.Forms.ComboBox modulyComboBox;
        private System.Windows.Forms.Button DodajLicencjeButton;
        private System.Windows.Forms.Button DodajPozycjeButton;
    }
}