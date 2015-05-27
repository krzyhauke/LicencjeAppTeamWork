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
    public partial class EdycjaBazDanychForm : Form
    {
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

        }

        private void DodajFirmeButton_Click(object sender, EventArgs e)
        {

        }

    }
}
