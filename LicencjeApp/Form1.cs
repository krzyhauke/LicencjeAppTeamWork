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

            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            this.pozycjaTableAdapter.Fill(this.licencjeDataSet.Pozycja);
            this.modulyTableAdapter.Fill(this.licencjeDataSet.Moduly);
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);
            TabelaDataGridView.DataSource = firmyBindingSource;
            PasekBindingNavigator.BindingSource = firmyBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Firmy";
        }

        private void firmyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);
            TabelaDataGridView.DataSource = firmyBindingSource;
            PasekBindingNavigator.BindingSource = firmyBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Firmy";
        }

        private void programyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            TabelaDataGridView.DataSource = programBindingSource;
            PasekBindingNavigator.BindingSource = programBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Programy";

        }

        private void modułyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.modulyTableAdapter.Fill(this.licencjeDataSet.Moduly);
            TabelaDataGridView.DataSource = modulyBindingSource;
            PasekBindingNavigator.BindingSource = modulyBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Moduły";
        }

        private void licencjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            TabelaDataGridView.DataSource = modulyBindingSource;
            PasekBindingNavigator.BindingSource = licencjaBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Licencje";
        }

        private void pozycjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pozycjaTableAdapter.Fill(this.licencjeDataSet.Pozycja);
            TabelaDataGridView.DataSource = licencjeDataSet.Pozycja;
            TabelaDataGridView.DataSource = pozycjaBindingSource;
            PasekBindingNavigator.BindingSource = licencjaBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Pozycje";
        }

        private void TabelaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;


        }
    }
}
