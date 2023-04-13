namespace Gestao_Estagios
{
    partial class Modificar
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
            this.txt_orientadores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ano = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.ComboBox();
            this.txt_Curso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.al_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al_ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cs_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_nome_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ano = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_orientadores
            // 
            this.txt_orientadores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_orientadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_orientadores.FormattingEnabled = true;
            this.txt_orientadores.Location = new System.Drawing.Point(27, 317);
            this.txt_orientadores.Name = "txt_orientadores";
            this.txt_orientadores.Size = new System.Drawing.Size(121, 24);
            this.txt_orientadores.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(23, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Orientadores";
            // 
            // Ano
            // 
            this.Ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ano.AutoSize = true;
            this.Ano.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ano.ForeColor = System.Drawing.Color.Gainsboro;
            this.Ano.Location = new System.Drawing.Point(23, 96);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(33, 16);
            this.Ano.TabIndex = 67;
            this.Ano.Text = "Ano";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_empresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_empresa.FormattingEnabled = true;
            this.txt_empresa.Location = new System.Drawing.Point(27, 267);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(121, 24);
            this.txt_empresa.TabIndex = 65;
            // 
            // txt_Curso
            // 
            this.txt_Curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Curso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Curso.FormattingEnabled = true;
            this.txt_Curso.Location = new System.Drawing.Point(26, 167);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(121, 24);
            this.txt_Curso.TabIndex = 64;
            this.txt_Curso.SelectedIndexChanged += new System.EventHandler(this.txt_Curso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(23, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(23, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Curso";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(116, 408);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(73, 23);
            this.txt_id.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(26, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 57;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(26, 361);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 32);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Atualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.Black;
            this.btn_insert.Location = new System.Drawing.Point(116, 361);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(73, 32);
            this.btn_insert.TabIndex = 55;
            this.btn_insert.Text = "Inserir";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Email.Location = new System.Drawing.Point(27, 218);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(120, 23);
            this.txt_Email.TabIndex = 54;
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Name.Location = new System.Drawing.Point(26, 60);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(120, 23);
            this.txt_Name.TabIndex = 53;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.al_id,
            this.al_nome,
            this.al_ano,
            this.cs_nome,
            this.al_email,
            this.ep_nome_empresa,
            this.ot_nome});
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(170, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(673, 284);
            this.dataGridView2.TabIndex = 70;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // al_id
            // 
            this.al_id.HeaderText = "ID";
            this.al_id.Name = "al_id";
            this.al_id.Width = 50;
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
            // txt_ano
            // 
            this.txt_ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ano.FormattingEnabled = true;
            this.txt_ano.Location = new System.Drawing.Point(25, 115);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(121, 21);
            this.txt_ano.TabIndex = 71;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(878, 483);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_orientadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.txt_Curso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Name);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_orientadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ano;
        private System.Windows.Forms.ComboBox txt_empresa;
        private System.Windows.Forms.ComboBox txt_Curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn cs_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn al_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_nome_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_nome;
        private System.Windows.Forms.ComboBox txt_ano;
    }
}