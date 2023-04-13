namespace Gestao_Estagios
{
    partial class Orientadores
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
            this.ot_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_telemovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ep_nome_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(99, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "reload";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ot_id,
            this.ot_telemovel,
            this.ot_email,
            this.ep_nome_empresa});
            this.dataGridView2.Location = new System.Drawing.Point(99, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 284);
            this.dataGridView2.TabIndex = 26;
            // 
            // ot_id
            // 
            this.ot_id.HeaderText = "Nome";
            this.ot_id.Name = "ot_id";
            // 
            // ot_telemovel
            // 
            this.ot_telemovel.HeaderText = "Telemovel";
            this.ot_telemovel.Name = "ot_telemovel";
            // 
            // ot_email
            // 
            this.ot_email.HeaderText = "Email";
            this.ot_email.Name = "ot_email";
            // 
            // ep_nome_empresa
            // 
            this.ep_nome_empresa.HeaderText = "Empresa";
            this.ep_nome_empresa.Name = "ep_nome_empresa";
            // 
            // Orientadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Orientadores";
            this.Text = "Orientadores";
            this.Load += new System.EventHandler(this.Orientadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_telemovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ep_nome_empresa;
    }
}