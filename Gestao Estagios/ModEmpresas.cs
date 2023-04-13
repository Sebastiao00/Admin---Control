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
    public partial class ModEmpresas : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();

        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public ModEmpresas()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();
            // vai selecionar todas as informações da tabela alunos e mostra-las na tabela
            string query = "SELECT * FROM Empresas";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["ep_id"].ToString(), row["ep_nome_empresa"].ToString(), row["ep_localidade"].ToString(), row["ep_telemovel"].ToString(), row["ep_email"].ToString(), row["ep_tutor"].ToString(), row["Area"].ToString());
                }
            }
            con.Close();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            //vai atualizar os dados do ID selecionado nos alunos
            MySqlCommand cmd3 = new MySqlCommand("UPDATE Empresas SET ep_nome_empresa = @ep_nome, ep_localidade = @localidade, ep_email = @email, ep_telemovel = @telemovel, ep_tutor = @tutor, area = @area WHERE ep_id = @id", conn);
            conn.Open();
            cmd3.Parameters.AddWithValue("@id", txt_id.Text);
            cmd3.Parameters.AddWithValue("@email", txt_email.Text);
            cmd3.Parameters.AddWithValue("@ep_nome", txt_Name.Text);
            cmd3.Parameters.AddWithValue("@localidade", txt_localidade.Text);
            cmd3.Parameters.AddWithValue("@telemovel", txt_telemovel.Text);
            cmd3.Parameters.AddWithValue("@tutor", txt_tutor.Text);
            cmd3.Parameters.AddWithValue("@area", txt_areas.Text);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Coluna atualizada com sucesso");
            dataGridView2.Rows.Clear();
            DisplayData();
        }

        private void ModEmpresas_Load(object sender, EventArgs e)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT ar_id, ar_definicao FROM area", conn))
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_areas.Items.Add(row["ar_id"] + " - " + row["ar_definicao"]);
                    }
                }
            }
            DisplayData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //vai pegar nas informações selecionadas numa coluna da tabela e coloca-las nas respetivas textboxes 
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            txt_id.Text = row.Cells[0].Value.ToString();
            txt_Name.Text = row.Cells[1].Value.ToString();
            txt_localidade.Text = row.Cells[2].Value.ToString();
            txt_telemovel.Text = row.Cells[3].Value.ToString();
            txt_tutor.Text = row.Cells[5].Value.ToString();
            txt_email.Text = row.Cells[4].Value.ToString();
            txt_areas.Text = row.Cells[6].Value.ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_Name.Text != "" && txt_localidade.Text != "" && txt_tutor.Text != "" && txt_areas.Text != "")
            {
                string nome = txt_Name.Text;
                string localidade = txt_localidade.Text;
                string email = txt_email.Text;
                string tutor = txt_tutor.Text;
                string tlm = txt_telemovel.Text;
                //vai inserir os dados das textboxes na databse
                MySqlCommand cmd = new MySqlCommand("insert into Empresas (ep_nome_empresa, ep_localidade, ep_telemovel, ep_tutor, ep_email, area) values ('" + nome + "', '" + localidade + "', '" + tlm + "', '" + tutor + "',, '" + email + "', '" + txt_areas.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Dados inseridos com sucesso!");
                txt_tutor.Text = "";
                txt_email.Text = "";
                txt_localidade.Text = "";
                txt_Name.Text = "";
                txt_areas.Text = "";
                txt_telemovel.Text = "";
                dataGridView2.Rows.Clear();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Por favor insira os dados.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_id.Text == "")
            {
                //vai aparecer caso o ID para eliminar nao esteja a ser referido
                MessageBox.Show("Por favor indique a coluna o ID da coluna que quer eliminar.");
            }
            else
            {
                // vai eliminar dados da database do ID selecionado
                int id = Convert.ToInt32(txt_id.Text);
                MySqlCommand cmd2 = new MySqlCommand("DELETE FROM Empresas WHERE ep_id = " + id, conn);
                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Coluna eliminada com sucesso");
                dataGridView2.Rows.Clear();
            }
            DisplayData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
