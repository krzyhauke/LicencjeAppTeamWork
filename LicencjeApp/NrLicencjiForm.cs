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

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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


        public void NrLicencjiForm_Load(object sender, EventArgs e)
        {

            string connstr = @"Data Source=192.168.1.10,49352;Initial Catalog=SprawdzanieLicencjiPraktykanci;Persist Security Info=True;User ID=sa;Password=dr5DR%ft6FT^";
            string query = "SELECT Nazwa" +
                           " FROM Program as tprog" +
                           " LEFT OUTER JOIN" +
                           " Licencja AS Lic ON tprog.ID = lic.ID_PROGRAMU";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connstr);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource pbs = new BindingSource();
            pbs.DataSource = table;
            ProgramyListBox.DataSource = pbs;

            ProgramyListBox.DisplayMember = "Nazwa";
           // pbs.Filter = "SELECT * FROM Program INNER JOIN Licencja ON Program.ID = Licencja.ID_PROGRAMU";



            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
            // TODO: This line of code loads data into the 'licencjeDataSet.Licencja' table. You can move, or remove it, as needed.
            this.licencjaTableAdapter.Fill(this.licencjeDataSet.Licencja);
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

       

        private void PDFButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.DefaultExt = "pdf";

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {

                string FilePath = savefiledialog.FileName;

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 45, 45);
                PdfWriter wPDF = PdfWriter.GetInstance(doc, new FileStream(FilePath, FileMode.Create));

                doc.Open();

                Paragraph FirmaiTEXT = new Paragraph(FirmaLabel.Text, FontFactory.GetFont("Verdana", 20));
                FirmaiTEXT.Alignment = Element.ALIGN_CENTER;


                doc.Add(FirmaiTEXT);

                Paragraph LicencjaiTEXT = new Paragraph(LicencjeListBox.Text, FontFactory.GetFont("Verdana", 12));
                LicencjaiTEXT.Alignment = Element.ALIGN_JUSTIFIED;

                doc.Add(LicencjaiTEXT);

                Paragraph programiTEXT = new Paragraph(ProgramyListBox.Text, FontFactory.GetFont("Verdana", 10));
                programiTEXT.Alignment = Element.ALIGN_RIGHT;

                doc.Add(programiTEXT);

                doc.Close();

                MessageBox.Show("Plik Został Zapisany");
            }


        }

      

       
        private void ProgramyListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
