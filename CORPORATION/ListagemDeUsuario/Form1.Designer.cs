namespace ListagemDeUsuario
{
    partial class ListagemUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(58, 121);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(748, 209);
            this.gridUsuarios.TabIndex = 3;
            this.gridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncionarios_CellContentClick);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(58, 92);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(145, 23);
            this.btnNovoUsuario.TabIndex = 4;
            this.btnNovoUsuario.Text = "NOVO USUÁRIO";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(209, 92);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(175, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "ALTERAR | EXCLUÍR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // ListagemUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.gridUsuarios);
            this.Name = "ListagemUsuario";
            this.Text = "Listagem De Usuário +";
            this.Load += new System.EventHandler(this.ListagemUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnAlterar;
    }
}

