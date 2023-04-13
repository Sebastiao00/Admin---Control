using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iText.Layout;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;


namespace Gestao_Estagios
{
    public partial class Tutores : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public Tutores()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();
            //vai selecionar todos os dados dos orientadores da database e mostra-los na tabela
            string query = "SELECT * FROM Empresas";
            MySqlDataReader row;

            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {

                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["ep_nome_empresa"].ToString(), row["ep_tutor"].ToString(), row["ep_telemovel"].ToString(), row["ep_email"].ToString(), row["ep_localidade"].ToString());


                }
                con2.Close();
            }
            con.Close();
        }
        private void Tutores_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            DisplayData();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Tutores.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView2.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView2.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView2.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
