using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestao_Estagios
{
    public partial class Resgisto : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gestaoestagio2;");
        public Resgisto()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //vai verificar se os campos estão preenchidos
            if (txt_Username.Text == "" && txt_password.Text == "" && txt_email.Text == "")
            {
                conn.Close();
                MessageBox.Show("Preencha os campos  para continuar");
            }
            else
            {
                //vai inserir os dados do utilizador na base de dados
                txt_password.Text = Encrypt.EncryptHN(txt_password.Text);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into utilizadores (ut_email, ut_first, ut_last, ut_pass, ut_admin) values ('" + txt_Username.Text + "', '" + txt_password.Text + "', '" + txt_email.Text + "', '" + txt_telemovel.Text + "', 'utilizador')", conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Bem vindo");

                this.Hide();
                Form1 form1 = new Form1();
                // vai esconder secções do menustrip
                form1.iconButton4.Visible = false;
                form1.ShowDialog();
                conn.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
