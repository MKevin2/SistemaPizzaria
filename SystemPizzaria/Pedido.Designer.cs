namespace SystemPizzaria
{
    partial class Pedido
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
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.txtValorOpcional = new System.Windows.Forms.TextBox();
            this.lblVpizza = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.llblVopcao = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(96, 394);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(95, 28);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(15, 29);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 1;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // txtValorOpcional
            // 
            this.txtValorOpcional.Location = new System.Drawing.Point(330, 63);
            this.txtValorOpcional.Name = "txtValorOpcional";
            this.txtValorOpcional.Size = new System.Drawing.Size(100, 20);
            this.txtValorOpcional.TabIndex = 2;
            // 
            // lblVpizza
            // 
            this.lblVpizza.AutoSize = true;
            this.lblVpizza.Location = new System.Drawing.Point(220, 38);
            this.lblVpizza.Name = "lblVpizza";
            this.lblVpizza.Size = new System.Drawing.Size(95, 13);
            this.lblVpizza.TabIndex = 3;
            this.lblVpizza.Text = "VALOR DA PIZZA";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(96, 245);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(442, 135);
            this.dgvPedido.TabIndex = 4;
            this.dgvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPedido_MouseDoubleClick);
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(81, 38);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(121, 21);
            this.cmbTamanhoPizza.TabIndex = 5;
            this.cmbTamanhoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // llblVopcao
            // 
            this.llblVopcao.AutoSize = true;
            this.llblVopcao.Location = new System.Drawing.Point(321, 38);
            this.llblVopcao.Name = "llblVopcao";
            this.llblVopcao.Size = new System.Drawing.Size(130, 13);
            this.llblVopcao.TabIndex = 6;
            this.llblVopcao.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(458, 39);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(92, 13);
            this.lblTotalPagar.TabIndex = 7;
            this.lblTotalPagar.Text = "TOTAL A PAGAR";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(218, 63);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(100, 20);
            this.txtValorPizza.TabIndex = 8;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(446, 62);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 9;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkTempero);
            this.grpOpcionais.Controls.Add(this.chkCatupiry);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Location = new System.Drawing.Point(81, 103);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(143, 127);
            this.grpOpcionais.TabIndex = 10;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "Escolha Opcionais";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(15, 102);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(108, 17);
            this.chkTempero.TabIndex = 13;
            this.chkTempero.Text = "Tempero do Chef";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(15, 79);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 12;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(15, 52);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 17);
            this.chkCebola.TabIndex = 11;
            this.chkCebola.Text = "Cebola sem choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(339, 182);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 11;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(264, 189);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 12;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 394);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 28);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(402, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 28);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(197, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 28);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Location = new System.Drawing.Point(81, 12);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(68, 20);
            this.txtCodPedido.TabIndex = 16;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 447);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.llblVopcao);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblVpizza);
            this.Controls.Add(this.txtValorOpcional);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.TextBox txtValorOpcional;
        private System.Windows.Forms.Label lblVpizza;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.Label llblVopcao;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodPedido;
    }
}