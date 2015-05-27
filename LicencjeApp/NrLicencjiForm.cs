using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicencjeApp
{
    public partial class NrLicencjiForm : Form
    {
        public NrLicencjiForm()
        {
            InitializeComponent();
        }

        public void PobierzDane(string nazwafirmy)
        {
            FirmaLabel.Text = nazwafirmy;
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
