using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Estagios
{
    public partial class ModUtilizadores : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public ModUtilizadores()
        {
            InitializeComponent();
        }

        private void ModUtilizadores_Load(object sender, EventArgs e)
        {
            //vai selecionar os dados da database
            using (MySqlCommand cmd = new MySqlCommand("SELECT tp_nome FROM tipo", conn))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        // vai apresentar os dados selecionados na combobox
                        txt_Permissoes.Items.Add(row["tp_nome"]);
                    }
                }
            }
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();
            // vai selecionar todos os dados dos utilizadores da database 
            string query = "SELECT * FROM utilizadores";
            MySqlDataReader row;

            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    // vai apresentar na tabela os dados da databse
                    dataGridView2.Rows.Add(row["ut_id"].ToString(), row["ut_username"].ToString(), row["ut_email"].ToString(), row["ut_telemovel"].ToString(), row["tipo"].ToString());

                    con2.Close();
                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txt_id.Text == "")
            {

                MessageBox.Show("Por favor indique a coluna o ID da coluna que quer eliminar.");

            }
            else
            {
                // vai eliminar os dados do utilizador selecionado através do ID
                int id = Convert.ToInt32(txt_id.Text);
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM utilizadores WHERE ut_id = " + id, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Coluna eliminada com sucesso");
                dataGridView2.Rows.Clear();
            }
            DisplayData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // vai atualizar os dados dos utilizador selecionado
            MySqlCommand cmd3 = new MySqlCommand("UPDATE Utilizadores SET ut_username = @ut_nome, ut_email = @ut_email, ut_telemovel = @tlm, tipo = @tipo WHERE ut_id = @id", conn);
            conn.Open();
            cmd3.Parameters.AddWithValue("@id", txt_id.Text);
            cmd3.Parameters.AddWithValue("@ut_nome", txt_Name.Text);
            cmd3.Parameters.AddWithValue("@ut_email", txt_email.Text);
            cmd3.Parameters.AddWithValue("@tlm", txt_tlm.Text);
            cmd3.Parameters.AddWithValue("@tipo", txt_Permissoes.Text);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Coluna atualizada com sucesso");
            dataGridView2.Rows.Clear();
            DisplayData();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //quando se clicar duas vezes numa tabela do datagrid vai pegar nos dados e coloca-los nas respetivas text boxes 
            int row = e.RowIndex;
            txt_id.Text = Convert.ToString(dataGridView2[0, row].Value);
            txt_Name.Text = Convert.ToString(dataGridView2[1, row].Value);
            txt_email.Text = Convert.ToString(dataGridView2[2, row].Value);
            txt_tlm.Text = Convert.ToString(dataGridView2[3, row].Value);
            txt_Permissoes.Text = Convert.ToString(dataGridView2[4, row].Value);
        }
    }
}
