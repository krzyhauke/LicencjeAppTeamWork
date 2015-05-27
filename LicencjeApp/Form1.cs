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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firmyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.firmyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.licencjeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'licencjeDataSet.Program' table. You can move, or remove it, as needed.
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            // TODO: This line of code loads data into the 'licencjeDataSet.Pozycja' table. You can move, or remove it, as needed.
            this.pozycjaTableAdapter.Fill(this.licencjeDataSet.Pozycja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Moduly' table. You can move, or remove it, as needed.
            this.modulyTableAdapter.Fill(this.licencjeDataSet.Moduly);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Firmy' table. You can move, or remove it, as needed.
            this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);

        }
    }
}
