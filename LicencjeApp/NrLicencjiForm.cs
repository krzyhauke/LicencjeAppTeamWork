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
    public partial class NrLicencjiForm : Form
    {
        public NrLicencjiForm()
        {
            InitializeComponent();
        }

        public void PobierzDane(string nazwafirmy, string idfirmy)
        {
            IDLabel.Text = idfirmy;
            FirmaLabel.Text = nazwafirmy;

            
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgramyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void NrLicencjiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'licencjeDataSet.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);

             
            
        }

        private void LicencjeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void licencjaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            licencjaBindingSource.Filter = "ID_FIRMY =" + IDLabel.Text;
        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }


        

    }
}
