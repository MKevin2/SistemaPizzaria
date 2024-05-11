namespace SystemPizzaria
{
    partial class Cliente
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnALterar = new System.Windows.Forms.Button();
            this.btnEcluir = new System.Windows.Forms.Button();
            this.brnCarregar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(90, 382);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 40);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(106, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "EMAIL:";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(423, 49);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 107);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(95, 211);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(383, 150);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCliente_MouseDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(181, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 40);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnALterar
            // 
            this.btnALterar.Location = new System.Drawing.Point(276, 382);
            this.btnALterar.Name = "btnALterar";
            this.btnALterar.Size = new System.Drawing.Size(75, 40);
            this.btnALterar.TabIndex = 5;
            this.btnALterar.Text = "ALTERAR";
            this.btnALterar.UseVisualStyleBackColor = true;
            this.btnALterar.Click += new System.EventHandler(this.btnALterar_Click);
            // 
            // btnEcluir
            // 
            this.btnEcluir.Location = new System.Drawing.Point(369, 382);
            this.btnEcluir.Name = "btnEcluir";
            this.btnEcluir.Size = new System.Drawing.Size(75, 40);
            this.btnEcluir.TabIndex = 6;
            this.btnEcluir.Text = "EXCLUIR";
            this.btnEcluir.UseVisualStyleBackColor = true;
            this.btnEcluir.Click += new System.EventHandler(this.btnEcluir_Click);
            // 
            // brnCarregar
            // 
            this.brnCarregar.Location = new System.Drawing.Point(423, 158);
            this.brnCarregar.Name = "brnCarregar";
            this.brnCarregar.Size = new System.Drawing.Size(100, 23);
            this.brnCarregar.TabIndex = 7;
            this.brnCarregar.Text = "carregar...";
            this.brnCarregar.UseVisualStyleBackColor = true;
            this.brnCarregar.Click += new System.EventHandler(this.brnCarregar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(168, 127);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(170, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(106, 134);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 13);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(106, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "NOME:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(238, 176);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 16;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged_1);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(160, 183);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(72, 13);
            this.lblPesquisar.TabIndex = 17;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(168, 12);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.ReadOnly = true;
            this.txtCodCli.Size = new System.Drawing.Size(64, 20);
            this.txtCodCli.TabIndex = 18;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 447);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.brnCarregar);
            this.Controls.Add(this.btnEcluir);
            this.Controls.Add(this.btnALterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnALterar;
        private System.Windows.Forms.Button btnEcluir;
        private System.Windows.Forms.Button brnCarregar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtCodCli;
    }
}