using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_geek_gabriel
{
    public partial class frmComprar : Form
    {
        public frmComprar()
        {
            InitializeComponent();
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbGabrielDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dbGabrielDataSet.produto);

        }
    }
}
