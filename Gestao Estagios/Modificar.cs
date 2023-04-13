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
    public partial class Modificar : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public Modificar()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();
            //seleciona todos os dados dos alunos da database
            string query = "SELECT * FROM alunos";
            MySqlDataReader row;

            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    //vai apresentar as informações nas colunas da tabela
                    dataGridView2.Rows.Add(row["al_id"].ToString(), row["al_nome"].ToString(), row["al_ano"].ToString(), row["cursos"].ToString(), row["al_email"].ToString(), row["Empresa"].ToString(), row["orientador"].ToString());
                }
            }
            con2.Close();
            con.Close();
        }
        private void Modificar_Load(object sender, EventArgs e)
        {

            // vai selecionar os nomes dos cursos e das empresas da database
            using (MySqlCommand cmd = new MySqlCommand("SELECT ep_nome_empresa FROM Empresas", conn))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // vai apresentar os campos nas respetivas comboboxes
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_empresa.Items.Add(row["ep_nome_empresa"]); 
                    }
                   
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT cs_nome FROM Cursos", conn))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // vai apresentar os campos nas respetivas comboboxes
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_Curso.Items.Add(row["cs_nome"]);
                    }

                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ano_ano FROM Ano", conn))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // vai apresentar os campos nas respetivas comboboxes
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_ano.Items.Add(row["ano_ano"]);
                    }
                }
            }
            using (MySqlCommand cmd = new MySqlCommand("SELECT ot_nome FROM orientador", conn))
            {

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // vai apresentar os campos nas respetivas comboboxes
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_orientadores.Items.Add(row["ot_nome"]);
                    }
                }
            }
            DisplayData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_ano.Text != "" && txt_Name.Text != "" && txt_Email.Text != "" && txt_Curso.Text != "" && txt_empresa.Text != "")
            {
                //cria uma variavel respectiva a cada textbox
                string nome = txt_Name.Text;
                string email = txt_Email.Text;
                string cursos = txt_Curso.Text;
                string ano = txt_ano.Text;

                //vai inserir os dados das textboxes na databse
                MySqlCommand cmd = new MySqlCommand("insert into alunos (al_nome, cursos, al_ano, al_email, Empresa, orientador) values ('" + nome + "', '" + cursos + "', '" + ano + "', '" + email + "', '" + txt_empresa.Text + "', '" + txt_orientadores.Text + "')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Dados inseridos com sucesso!");

                //vai limpar o texto das textboxes após inserir os dados
                txt_Curso.Text = "";
                txt_Email.Text = "";
                txt_Name.Text = "";
                txt_empresa.Text = "";
                txt_ano.Text = "";
                txt_orientadores.Text = "";
                dataGridView2.Rows.Clear();
                DisplayData();
            }
            else
            {
                //vai aparecer caso todas as textboxes nao estejam preenchidas
                MessageBox.Show("Por favor insira os dados.");
            }
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
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM alunos WHERE al_id = " + id, conn);
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
            //vai atualizar os dados do ID selecionado nos alunos
            MySqlCommand cmd3 = new MySqlCommand("UPDATE alunos SET al_nome = @al_nome, al_email = @al_email, cursos = @curso, Empresa = @empresa, orientador = @orientador WHERE al_id = @id", conn);
            conn.Open();
            cmd3.Parameters.AddWithValue("@id", txt_id.Text);
            cmd3.Parameters.AddWithValue("@al_nome", txt_Name.Text);
            cmd3.Parameters.AddWithValue("@al_email", txt_Email.Text);
            cmd3.Parameters.AddWithValue("@curso", txt_Curso.Text);
            cmd3.Parameters.AddWithValue("@empresa", txt_empresa.Text);
            cmd3.Parameters.AddWithValue("@orientador", txt_orientadores.Text);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Coluna atualizada com sucesso");
            dataGridView2.Rows.Clear();
            DisplayData();
        }

        private void txt_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //vai pegar nas informações selecionadas numa coluna da tabela e coloca-las nas respetivas textboxes 
            int row = e.RowIndex;
            txt_id.Text = Convert.ToString(dataGridView2[0, row].Value);
            txt_Name.Text = Convert.ToString(dataGridView2[1, row].Value);
            txt_ano.Text = Convert.ToString(dataGridView2[2, row].Value);
            txt_Curso.Text = Convert.ToString(dataGridView2[3, row].Value);
            txt_Email.Text = Convert.ToString(dataGridView2[4, row].Value);
            txt_empresa.Text = Convert.ToString(dataGridView2[5, row].Value);
        }
    }
}
