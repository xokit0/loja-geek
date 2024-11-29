namespace loja_geek_gabriel
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnGrafico);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Controls.Add(this.btnComprar);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 730);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Image = global::loja_geek_gabriel.Properties.Resources.sair__1_;
            this.btnSair.Location = new System.Drawing.Point(0, 654);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 76);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.Leave += new System.EventHandler(this.btnSair_Leave);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrafico.FlatAppearance.BorderSize = 0;
            this.btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrafico.Image = global::loja_geek_gabriel.Properties.Resources.grafico_de_crescimento__1_;
            this.btnGrafico.Location = new System.Drawing.Point(0, 448);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(200, 76);
            this.btnGrafico.TabIndex = 1;
            this.btnGrafico.Text = "Gráfico de Vendas";
            this.btnGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            this.btnGrafico.Leave += new System.EventHandler(this.btnGrafico_Leave);
            // 
            // btnProduto
            // 
            this.btnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProduto.Image = global::loja_geek_gabriel.Properties.Resources.caixa__1_;
            this.btnProduto.Location = new System.Drawing.Point(0, 372);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(200, 76);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            this.btnProduto.Leave += new System.EventHandler(this.btnProduto_Leave);
            // 
            // btnComprar
            // 
            this.btnComprar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComprar.Image = global::loja_geek_gabriel.Properties.Resources.carrinho__1_;
            this.btnComprar.Location = new System.Drawing.Point(0, 296);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(200, 76);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            this.btnComprar.Leave += new System.EventHandler(this.btnComprar_Leave);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerfil.Image = global::loja_geek_gabriel.Properties.Resources.usuario_de_perfil__1_;
            this.btnPerfil.Location = new System.Drawing.Point(0, 220);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(200, 76);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            this.btnPerfil.Leave += new System.EventHandler(this.btnPerfil_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 220);
            this.panel2.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(43, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(105, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::loja_geek_gabriel.Properties.Resources.usuario_de_perfil;
            this.pictureBox1.Location = new System.Drawing.Point(30, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNav
            // 
            this.pnlNav.Location = new System.Drawing.Point(0, 196);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 1;
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBoard.Location = new System.Drawing.Point(200, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(963, 730);
            this.pnlBoard.TabIndex = 2;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1163, 730);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

