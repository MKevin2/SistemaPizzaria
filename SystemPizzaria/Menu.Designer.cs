namespace SystemPizzaria
{
    partial class Menu
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnConteudo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnSair);
            this.pnMenu.Controls.Add(this.btnInicio);
            this.pnMenu.Controls.Add(this.btnPedido);
            this.pnMenu.Controls.Add(this.btnCliente);
            this.pnMenu.Location = new System.Drawing.Point(60, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(133, 486);
            this.pnMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(21, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 46);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(21, 67);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(92, 46);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(21, 214);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(92, 49);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.Text = "PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(21, 136);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(92, 49);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // pnConteudo
            // 
            this.pnConteudo.Controls.Add(this.label2);
            this.pnConteudo.Controls.Add(this.label1);
            this.pnConteudo.Location = new System.Drawing.Point(199, 2);
            this.pnConteudo.Name = "pnConteudo";
            this.pnConteudo.Size = new System.Drawing.Size(589, 486);
            this.pnConteudo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIZZARIA ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(221, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Version:1.0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnConteudo);
            this.Controls.Add(this.pnMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.pnMenu.ResumeLayout(false);
            this.pnConteudo.ResumeLayout(false);
            this.pnConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnConteudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}