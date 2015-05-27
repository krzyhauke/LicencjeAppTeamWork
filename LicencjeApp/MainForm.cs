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
    public partial class MainForm : Form
    {
        public MainForm()
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
            TabelaDataGridView.DataSource = licencjaBindingSource;
            PasekBindingNavigator.BindingSource = licencjaBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Licencje";
        }

        private void pozycjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pozycjaTableAdapter.Fill(this.licencjeDataSet.Pozycja);
            TabelaDataGridView.DataSource = licencjeDataSet.Pozycja;
            TabelaDataGridView.DataSource = pozycjaBindingSource;
            PasekBindingNavigator.BindingSource = pozycjaBindingSource;
            WybierzBazeDanychToolStripDropDownButton.Text = "Baza danych: Pozycje";
        }

        private void TabelaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string nazwaFirmy = TabelaDataGridView.Rows[row].Cells[1].Value.ToString();
            string idFirmy = TabelaDataGridView.Rows[row].Cells[0].Value.ToString();

            NrLicencjiForm licencjaform = new NrLicencjiForm();

            licencjaform.PobierzDane(nazwaFirmy,idFirmy);
            licencjaform.Show();

        }

        private void edycjaBazyDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdycjaBazDanychForm EdycjaBazDanychForm = new EdycjaBazDanychForm();
            EdycjaBazDanychForm.Show();
        }

        private void RefreshStripButton1_Click(object sender, EventArgs e)
        {
            if (TabelaDataGridView.DataSource == firmyBindingSource)
            {
                this.firmyTableAdapter.Fill(this.licencjeDataSet.Firmy);
                TabelaDataGridView.DataSource = firmyBindingSource;
            }
            else if (TabelaDataGridView.DataSource == licencjaBindingSource)
            {
                this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
                TabelaDataGridView.DataSource = licencjaBindingSource;
            }
            else if (TabelaDataGridView.DataSource == modulyBindingSource)
            {
                this.modulyTableAdapter.Fill(this.licencjeDataSet.Moduly);
                TabelaDataGridView.DataSource = modulyBindingSource;
            }
            else if (TabelaDataGridView.DataSource == pozycjaBindingSource)
            {
                this.pozycjaTableAdapter.Fill(this.licencjeDataSet.Pozycja);
                TabelaDataGridView.DataSource = pozycjaBindingSource;
            }
            else if (TabelaDataGridView.DataSource==programBindingSource)
            {
                this.programTableAdapter.Fill(this.licencjeDataSet.Program);
                TabelaDataGridView.DataSource = programBindingSource;
            }
            
        }

  
    }
}
