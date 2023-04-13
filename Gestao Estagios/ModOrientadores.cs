using FontAwesome.Sharp;
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
    public partial class ModOrientadores : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public ModOrientadores()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {

            con.Open();
            con2.Open();
            // vai selecionar todas as informações da tabela alunos e mostra-las na tabela
            string query = "SELECT * FROM orientador";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["ot_id"].ToString(), row["ot_nome"].ToString(), row["ot_email"].ToString(), row["ot_telemovel"].ToString(), row["Empresa"].ToString());
                    con2.Close();
                }
            }
            con.Close();
        }

        private void ModOrientadores_Load(object sender, EventArgs e)
        {

            //vai selecionar o nome das empresas da database 
            using (MySqlCommand cmd = new MySqlCommand("SELECT ep_nome_empresa FROM Empresas", conn))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        // vai mostrar os nomes das empresas na combobox
                        txt_empresa.Items.Add(row["ep_nome_empresa"]);
                    }
                }
            }
            DisplayData();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string nome = txt_Name.Text;
            string email = txt_email.Text;
            string tlm = txt_telemovel.Text;
            //vai atualizar os dados do ID selecionado nos alunos
            MySqlCommand cmd3 = new MySqlCommand("UPDATE orientador SET ot_nome = '" + nome + "', ot_email = '" + email + "', ot_telemovel =  '" + tlm + "', Empresa =  '" + txt_empresa.Text + "' WHERE ot_id = '" + txt_id.Text + "'", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Coluna atualizada com sucesso");
            dataGridView2.Rows.Clear();
            DisplayData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_Name.Text != "" && txt_email.Text != "" && txt_telemovel.Text != "")
            {
                string nome = txt_Name.Text;
                string email = txt_email.Text;
                string tlm = txt_telemovel.Text;
                //vai inserir os dados das textboxes na databse
                MySqlCommand cmd = new MySqlCommand("insert into orientador (ot_nome, ot_email, ot_telemovel, Empresa) values ('" + nome + "', '" + email + "', '" + tlm + "', '" + txt_empresa.Text + "')", conn);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Dados inseridos com sucesso!");

                txt_email.Text = "";
                txt_Name.Text = "";
                txt_telemovel.Text = "";
                dataGridView2.Rows.Clear();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Por favor insira os dados.");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                //vai aparecer caso o ID para eliminar nao esteja a ser referido
                MessageBox.Show("Por favor indique a coluna o ID da coluna que quer eliminar.");
            }
            else
            {
                // vai eliminar dados da database do ID selecionado
                int id = Convert.ToInt32(txt_id.Text);
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM orientador WHERE ot_id = " + id, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Coluna eliminada com sucesso");
                dataGridView2.Rows.Clear();
            }
            DisplayData();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //vai pegar nas informações selecionadas numa coluna da tabela e coloca-las nas respetivas textboxes 
            int row = e.RowIndex;
            txt_id.Text = Convert.ToString(dataGridView2[0, row].Value);
            txt_Name.Text = Convert.ToString(dataGridView2[1, row].Value);
            txt_email.Text = Convert.ToString(dataGridView2[2, row].Value);
            txt_telemovel.Text = Convert.ToString(dataGridView2[3, row].Value);
            txt_empresa.Text = Convert.ToString(dataGridView2[4, row].Value);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
