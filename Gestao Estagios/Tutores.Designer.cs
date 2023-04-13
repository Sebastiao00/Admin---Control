namespace Gestao_Estagios
{
    partial class Tutores
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ep_nome_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_telemovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_localidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(110, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "reload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ep_nome_empresa,
            this.ep_tutor,
            this.ep_telemovel,
            this.ep_email,
            this.ep_localidade});
            this.dataGridView2.Location = new System.Drawing.Point(110, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(573, 284);
            this.dataGridView2.TabIndex = 26;
            // 
            // ep_nome_empresa
            // 
            this.ep_nome_empresa.HeaderText = "Empresa";
            this.ep_nome_empresa.Name = "ep_nome_empresa";
            // 
            // ep_tutor
            // 
            this.ep_tutor.HeaderText = "Nome do Tutor";
            this.ep_tutor.Name = "ep_tutor";
            this.ep_tutor.Width = 120;
            // 
            // ep_telemovel
            // 
            this.ep_telemovel.HeaderText = "Telemovel";
            this.ep_telemovel.Name = "ep_telemovel";
            // 
            // ep_email
            // 
            this.ep_email.HeaderText = "Email";
            this.ep_email.Name = "ep_email";
            this.ep_email.Width = 110;
            // 
            // ep_localidade
            // 
            this.ep_localidade.HeaderText = "Localidade";
            this.ep_localidade.Name = "ep_localidade";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(110, 350);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(81, 30);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Tutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Tutores";
            this.Text = "Tutores";
            this.Load += new System.EventHandler(this.Tutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_nome_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_telemovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_localidade;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}