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
        public string connectionString = "Data Source=78.10.88.200,49352;Initial Catalog=SprawdzanieLicencjiPraktykanci;Persist Security Info=True;User ID=sa;Password=dr5DR%ft6FT^";
        public string idProgramu;
        public string NazwaProgramu;
        

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

            this.programTableAdapter.Fill(this.licencjeDataSet.Program);
            this.programTableAdapter.Fill(this.licencjeDataSet.Program);

           }

        private void PDFButton_Click(object sender, EventArgs e)
        {
            PobranieNazwyIIdProgramu();
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.DefaultExt = "pdf";

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {

                string FilePath = savefiledialog.FileName;

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 45, 45);
                PdfWriter wPDF = PdfWriter.GetInstance(doc, new FileStream(FilePath, FileMode.Create));

                doc.Open();

                Paragraph FirmaiTEXT = new Paragraph(FirmaLabel.Text, FontFactory.GetFont("Verdana", 30));
                FirmaiTEXT.Alignment = Element.ALIGN_CENTER;


                doc.Add(FirmaiTEXT);

               Paragraph LicencjaiTEXT = new Paragraph("\n\n Licencja: " + nUMER_LICENCJIListBox.Text, FontFactory.GetFont("Verdana", 12));
                LicencjaiTEXT.Alignment = Element.ALIGN_JUSTIFIED;

                doc.Add(LicencjaiTEXT);

                Paragraph programiTEXT = new Paragraph("\n\n" + NazwaProgramu, FontFactory.GetFont("Verdana", 10));
                programiTEXT.Alignment = Element.ALIGN_RIGHT;

                doc.Add(programiTEXT);

                doc.Close();

                MessageBox.Show("Plik Został Zapisany");
            }
            

        }


        private void programDataGridView_Click(object sender, EventArgs e)
        {
            List<String> ListaLicencji = new List<String>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT NUMER_LICENCJI FROM LICENCJA WHERE ID_FIRMY='" + Convert.ToInt32(IDLabel.Text) + "' AND ID_PROGRAMU ='" + idProgramu + "'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string NumerLicencjiX = reader["NUMER_LICENCJI"].ToString();
                            ListaLicencji.Add(NumerLicencjiX);
                        }
                    }

                }
            }
            nUMER_LICENCJIListBox.DataSource = ListaLicencji;

            PobranieNazwyIIdProgramu();





        }

        private void PobranieNazwyIIdProgramu()
        {
            int row = Convert.ToInt32(programDataGridView.CurrentRow.Index);
            idProgramu = programDataGridView.Rows[row].Cells[0].Value.ToString();
            NazwaProgramu = programDataGridView.Rows[row].Cells[1].Value.ToString();
        }

    }
}