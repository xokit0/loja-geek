using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.SqlServer.Server;
using System.Drawing.Configuration;

namespace loja_geek_gabriel
{
    public partial class frmMenu : Form
    {

        [DllImport("Gdi32.d11", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public frmMenu()
        {
            InitializeComponent();
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnPerfil.Height;
            pnlNav.Top = btnPerfil.Top;
            pnlNav.Left = btnPerfil.Left;
            pnlNav.BackColor = Color.FromArgb(46, 51, 73);


            this.pnlBoard.Controls.Clear();
            frmGrafico grafico = new frmGrafico() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            grafico.FormBorderStyle = FormBorderStyle.None;
            this.pnlBoard.Controls.Add(grafico);
            grafico.Show();


        }   



                                           //   Click nos botoes da interface

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPerfil.Height;
            pnlNav.Top = btnPerfil.Top;
            pnlNav.Left = btnPerfil.Left;
            pnlNav.BackColor = Color.FromArgb(77, 88, 99);

            this.pnlBoard.Controls.Clear();
            frmPerfil perfil = new frmPerfil() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            perfil.FormBorderStyle = FormBorderStyle.None;
            this.pnlBoard.Controls.Add(perfil);
            perfil.Show();


        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnComprar.Height;
            pnlNav.Top = btnComprar.Top;
            pnlNav.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlBoard.Controls.Clear();
            frmComprar comprar = new frmComprar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            comprar.FormBorderStyle = FormBorderStyle.None;
            this.pnlBoard.Controls.Add(comprar);
            comprar.Show();


        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnProduto.Height;
            pnlNav.Top = btnProduto.Top;
            pnlNav.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlBoard.Controls.Clear();
            frmProduto produto = new frmProduto() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            produto.FormBorderStyle = FormBorderStyle.None;
            this.pnlBoard.Controls.Add(produto);
            produto.Show();

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGrafico.Height;
            pnlNav.Top = btnGrafico.Top;
            pnlNav.BackColor = Color.FromArgb(46, 51, 73);


            this.pnlBoard.Controls.Clear();
            frmGrafico grafico = new frmGrafico() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            grafico.FormBorderStyle = FormBorderStyle.None;
            this.pnlBoard.Controls.Add(grafico);
            grafico.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            pnlNav.Height = btnSair.Height;
            pnlNav.Top = btnSair.Top;
            pnlNav.BackColor = Color.FromArgb(47, 79, 79);
        }

                                           // Ao sair dos botoes
        private void btnPerfil_Leave(object sender, EventArgs e)
        {
            btnPerfil.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnComprar_Leave(object sender, EventArgs e)
        {
            btnComprar.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnProduto_Leave(object sender, EventArgs e)
        {
            btnProduto.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnGrafico_Leave(object sender, EventArgs e)
        {
            btnGrafico.BackColor = Color.FromArgb(47, 79, 79);
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(47, 79, 79);
        }
    }
}
