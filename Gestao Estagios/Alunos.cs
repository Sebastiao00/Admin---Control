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
    public partial class Alunos : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public Alunos()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();

            string query = "SELECT * FROM alunos";
            MySqlDataReader row;

            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["al_nome"].ToString(), row["al_ano"].ToString(), row["cursos"].ToString(), row["al_email"].ToString(), row["Empresa"].ToString(), row["orientador"].ToString());

                    con2.Close();
                }
            }
            con.Close();
        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT ano_ano, cs_nome FROM Ano, Cursos", conn))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_ano.Items.Add(row["ano_ano"]); 
                        txt_curso.Items.Add(row["cs_nome"]);
                    }
                    
                }
            }
            DisplayData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            con.Open();
            con2.Open();
            dataGridView2.Rows.Clear();
            string cursos = txt_curso.Text;
            string ano = txt_ano.Text;
            string query = "SELECT * FROM alunos where cursos = '"+cursos+ "' and al_ano = '" + ano+"'";
            MySqlDataReader row;

            row = con.ExecuteReader(query);
            if(!row.HasRows)
            {
                MessageBox.Show("Não foram encontrados dados com as informações selecionadas");
                DisplayData();
            }
            if (row.HasRows)
            {
                while (row.Read())
                {
                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["al_nome"].ToString(), row["al_ano"].ToString(), row["cursos"].ToString(), row["al_email"].ToString(), row["Empresa"].ToString(), row["orientador"].ToString());

                    con2.Close();
                }
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_click(object sender, EventArgs e)
        {
                if (dataGridView2.Rows.Count > 0)
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "PDF (*.pdf)|*.pdf";
                    save.FileName = "Alunos.pdf";
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
