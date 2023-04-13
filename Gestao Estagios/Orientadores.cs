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
    public partial class Orientadores : Form
    {
        ConnectionBD con = new ConnectionBD();
        ConnectionBD con2 = new ConnectionBD();
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public Orientadores()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            con.Open();
            con2.Open();
            //vai selecionar todos os dados dos orientadores da database e mostra-los na tabela
            string query = "SELECT * FROM orientador";
            MySqlDataReader row;

            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {

                    //vai inserir os dados da databse nas colunas da tabela
                    dataGridView2.Rows.Add(row["ot_nome"].ToString(), row["ot_telemovel"].ToString(), row["ot_email"].ToString(), row["Empresa"].ToString());


                }
                con2.Close();
            }
            con.Close();
        }

        private void Orientadores_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            DisplayData();
        }
    }
}
