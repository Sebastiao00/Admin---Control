using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Gestao_Estagios
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(67, 154, 151);
            public static Color color2 = Color.FromArgb(98, 182, 183);
            public static Color color3 = Color.FromArgb(151, 222, 206);
            public static Color color4 = Color.FromArgb(203, 237, 213);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(29, 117, 149);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;

            }
        }
        private void ActiveButton2(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(29, 117, 149);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Icon Current Child Form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(29, 117, 149);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm=childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text= childForm.Text;
        }
        private void OpenForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();

            label1.Text=DateTime.Now.ToLongDateString();

            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Alunos());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Orientadores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Tutores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        public void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new Modificar());
            btnAlunos.Visible = true;
            BtnEmpresas.Visible = true;
            BtnUtilizadores.Visible = true;
            BtnOrientadores.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
                btnAlunos.Visible = false;
                BtnEmpresas.Visible = false;
                BtnUtilizadores.Visible = false;
                BtnOrientadores.Visible = false;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible= false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Home";
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            ActiveButton2(sender, RGBColors.color4);
            OpenChildForm(new Modificar());
        }

        private void BtnOrientadores_Click(object sender, EventArgs e)
        {
            ActiveButton2(sender, RGBColors.color4);
            OpenForm(new ModOrientadores());
        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {
            ActiveButton2(sender, RGBColors.color4);
            OpenForm(new ModEmpresas());
        }

        private void BtnUtilizadores_Click(object sender, EventArgs e)
        {
            ActiveButton2(sender, RGBColors.color4);
            OpenForm(new ModUtilizadores());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState= FormWindowState.Maximized;
            }
            else
            {
                WindowState= FormWindowState.Normal;
            }
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new Alunos());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Orientadores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Tutores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        public void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new Modificar());
            btnAlunos.Visible = true;
            BtnEmpresas.Visible = true;
            BtnUtilizadores.Visible = true;
            BtnOrientadores.Visible = true;
        }

        private void iconButton2_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new Orientadores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton3_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Tutores());
            btnAlunos.Visible = false;
            BtnEmpresas.Visible = false;
            BtnUtilizadores.Visible = false;
            BtnOrientadores.Visible = false;
        }

        private void iconButton4_Click_2(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new Modificar());
            btnAlunos.Visible = true;
            BtnEmpresas.Visible = true;
            BtnUtilizadores.Visible = true;
            BtnOrientadores.Visible = true;
        }

        private void iconSairUtilizador_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void iconMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
