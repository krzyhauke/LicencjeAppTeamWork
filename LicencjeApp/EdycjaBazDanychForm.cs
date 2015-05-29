using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LicencjeApp
{
    public partial class EdycjaBazDanychForm : Form
    {
        public string connectionString = "Data Source=78.10.88.200,49352;Initial Catalog=SprawdzanieLicencjiPraktykanci;Persist Security Info=True;User ID=sa;Password=dr5DR%ft6FT^";
       
        public EdycjaBazDanychForm()
        {
            InitializeComponent();
        }
        
        private void EdycjaBazDanychForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'licencjeDataSet.Moduly' table. You can move, or remove it, as needed.
            this.modulyTableAdapter.Fill(this.licencjeDataSet.Moduly);
            // TODO: This line of code loads data into the 'licencjeDataSet.Firmy' table. You can move, or remove it, as needed.
            this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);
            // TODO: This line of code loads data into the 'licencjeDataSet.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SprawdzPoloczenietoolStripStatusLabel.Text = "Połączono";
                conn.Close();
            }
            catch (Exception ex)
            {
                SprawdzPoloczenietoolStripStatusLabel.Text = "Nie połączono";
                MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataOddateTimePicker.Value = DateTime.Today;
            DataDodateTimePicker.Value = DateTime.Today;
        }

        private void DodajFirmeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Firmy (NAZWA, NIP, ADRES, Miejscowosc, email, telefon) VALUES ('" + NazwaFirmyTextBox.Text + "','" + NipFirmyTextBox.Text.ToString() + "','" + AdresFirmyTextBox.Text.ToString() + "','" + MiejscowoscFirmyTextBox.Text.ToString() + "','" + EmailFirmyTextBox.Text.ToString() + "','" + telefonTextBox.Text.ToString() + "');";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Dodano rekord do bazy danych", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            NazwaFirmyTextBox.Text = null;
            NipFirmyTextBox.Text = null;
            AdresFirmyTextBox.Text = null;
            MiejscowoscFirmyTextBox.Text = null;
            EmailFirmyTextBox.Text = null;
            telefonTextBox.Text = null;
            this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);
            firmyPozycjeComboBox1.DataSource = firmyBindingSource;
            firmyLicencjeComboBox.DataSource = firmyBindingSource;

            

        }




        private void DodajProgramButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Program (Nazwa) VALUES ('" + NazwaProgramyTextBox.Text + "');";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Dodano rekord do bazy danych", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            NazwaProgramyTextBox.Text = null;
            this.programTableAdapter.Fill(licencjeDataSet.Program);
            programComboBox.DataSource = programBindingSource;
            programComboBox1.DataSource = programBindingSource;
        }

        private void DodajModulButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Moduly (KOD, Nazwa, ID_PROGRAMU) VALUES ('" + KodModulyTextBox.Text + "','" + NazwaModulyTextBox.Text + "','" + programComboBox.SelectedValue.ToString() + "');";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Dodano rekord do bazy danych", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            KodModulyTextBox.Text = null;
            NazwaModulyTextBox.Text = null;
            programComboBox.SelectedIndex = 0;
            this.modulyTableAdapter.Fill(licencjeDataSet.Moduly);
            modulyComboBox.DataSource = modulyBindingSource;
        }

        private void DodajLicencjeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Licencja (ID_FIRMY, NUMER_LICENCJI, DATA_OD, DATA_DO, Ilosc, Cena, ID_PROGRAMU) VALUES ('"+firmyLicencjeComboBox.SelectedValue+"','"+NumerLicencjiTextBox.Text+"','"+DataOddateTimePicker.Value+"','"+DataDodateTimePicker.Value+"','"+IloscLicencjinumericUpDown.Value.ToString()+"','"+CenaLicencjinumericUpDown2.Value.ToString()+"','"+programComboBox1.SelectedValue+"')";                
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Dodano rekord do bazy danych", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            firmyLicencjeComboBox.SelectedIndex = 0;
            programComboBox1.SelectedIndex = 0;
            NumerLicencjiTextBox.Text = null;
            DataOddateTimePicker.Value = DateTime.Today;
            DataDodateTimePicker.Value = DateTime.Today;
            IloscLicencjinumericUpDown.Value = 1;
            CenaLicencjinumericUpDown2.Value = 0;
        }

        private void DodajPozycjeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Pozycja (ID_Firmy, ID_Modulu) VALUES ('" + firmyPozycjeComboBox1.SelectedValue + "','" + modulyComboBox.SelectedValue + "')"; cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Dodano rekord do bazy danych", "Powiadomienie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            firmyPozycjeComboBox1.SelectedIndex = 0;
            modulyComboBox.SelectedIndex = 0;
        }

    }
}