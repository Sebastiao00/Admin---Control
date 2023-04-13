namespace Gestao_Estagios
{
    partial class Alunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.al_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al_ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_nome_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_curso = new System.Windows.Forms.ComboBox();
            this.txt_ano = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pesquisa = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(83, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "reload";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.al_nome,
            this.al_ano,
            this.cs_nome,
            this.al_email,
            this.ep_nome_empresa,
            this.ot_nome});
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridView2.Location = new System.Drawing.Point(83, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(622, 284);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // al_nome
            // 
            this.al_nome.HeaderText = "Nome";
            this.al_nome.Name = "al_nome";
            // 
            // al_ano
            // 
            this.al_ano.HeaderText = "Ano";
            this.al_ano.Name = "al_ano";
            this.al_ano.Width = 50;
            // 
            // cs_nome
            // 
            this.cs_nome.HeaderText = "Curso";
            this.cs_nome.Name = "cs_nome";
            // 
            // al_email
            // 
            this.al_email.HeaderText = "Email";
            this.al_email.Name = "al_email";
            // 
            // ep_nome_empresa
            // 
            this.ep_nome_empresa.HeaderText = "Empresa";
            this.ep_nome_empresa.Name = "ep_nome_empresa";
            this.ep_nome_empresa.Width = 130;
            // 
            // ot_nome
            // 
            this.ot_nome.HeaderText = "Orientador";
            this.ot_nome.Name = "ot_nome";
            // 
            // txt_curso
            // 
            this.txt_curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_curso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_curso.ForeColor = System.Drawing.Color.Black;
            this.txt_curso.FormattingEnabled = true;
            this.txt_curso.Location = new System.Drawing.Point(83, 351);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(274, 24);
            this.txt_curso.TabIndex = 25;
            this.txt_curso.SelectedIndexChanged += new System.EventHandler(this.txt_curso_SelectedIndexChanged);
            // 
            // txt_ano
            // 
            this.txt_ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ano.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ano.ForeColor = System.Drawing.Color.Black;
            this.txt_ano.FormattingEnabled = true;
            this.txt_ano.Location = new System.Drawing.Point(363, 351);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(61, 24);
            this.txt_ano.TabIndex = 26;
            this.txt_ano.SelectedIndexChanged += new System.EventHandler(this.txt_ano_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cursos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ano";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_pesquisa.IconColor = System.Drawing.Color.Black;
            this.btn_pesquisa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_pesquisa.Location = new System.Drawing.Point(440, 345);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(81, 30);
            this.btn_pesquisa.TabIndex = 29;
            this.btn_pesquisa.Text = "Pesquisar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(545, 345);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(81, 30);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_click);
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_nome_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_nome;
        private System.Windows.Forms.ComboBox txt_curso;
        private System.Windows.Forms.ComboBox txt_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_pesquisa;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}