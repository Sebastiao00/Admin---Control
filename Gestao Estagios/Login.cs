using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestao_Estagios
{
    public partial class Login : Form
    {
        string tipoReader = default;
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password='';database=project;");
        public Login()
        {
            InitializeComponent();
        }
        /*
        public string Encryptor(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }*/
        private void login()
        {
            /*
            string email = lg_email.Text;
            string password = Encrypt.EncryptHN(textBoxPassword.Text);

            if (String.IsNullOrEmpty(email) && String.IsNullOrEmpty(password))
            {

                MessageBox.Show("Os campos têm que ser preenchidos!", "Arquivos EPBJC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("O campo do utilizador não pode estar vazio!", "Arquivos EPBJC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = lg_email;
            }
            else if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("O campo da palavra-passe não pode estar vazio!", "Arquivos EPBJC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = textBoxPassword;
            }
            else
            {
                /*
                //Encripta a palavra-passe
                string passwordEncrypt = Encryptor.Encrypt(password);
                */
            /*
                //Codigo SQL
                string query = "SELECT * FROM utilizadores WHERE ut_email = @email AND ut_password = @Password";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", email);
                command.Parameters.AddWithValue("@Password", password);

                //Cria as variaveis nessesárias
                MySqlDataReader dataReader;
                string usernameReader = default;
                string passwordReader = default;
                //Vai tentar executar o comando

                conn.Open();
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    usernameReader = dataReader.GetString("ut_username");
                    passwordReader = dataReader.GetString("ut_password");
                    tipoReader = dataReader.GetString("tipo");
                }
                //Vai verificar se as palavras-passes coicidem
                if (usernameReader == username && passwordReader == password)
                {
                    //Login
                    this.Hide();
                    Form1 form1 = new Form1();
                    //vai verificar o tipo de utilizador da conta e dependendo do tipo irá esconder ou mostrar determinadas opções do menu
                    if (tipoReader == "admin")
                    {
                        form1.iconButton4.Visible = true;
                        form1.ShowDialog();
                    }
                    else if (tipoReader == "utilizador")
                    {
                        form1.iconButton4.Visible = false;
                        form1.ShowDialog();
                    }
                    else
                    {
                        form1.ShowDialog();
                    }

                }
                else
                {
                    //Altera o texto das mensagens de erro
                    MessageBox.Show("Nome de utilizador ou palavra-passe incorretos!", "Arquivos EPBJC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
            */
        }
            
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(59, 161, 197);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(30, 120, 152);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resgisto Resgisto = new Resgisto();
            Resgisto.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.SendToBack();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
