using loja_geek_gabriel.Models;
using loja_geek_gabriel.Controller;
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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecionar imagem...";
            dialog.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Todos os Arquivos|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagem = dialog.FileName;
                pbxFoto.ImageLocation = imagem;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtValor.Text == string.Empty)
            {
                MessageBox.Show("Por favor, preencha todos os campos do formulário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ConProduto produto = new ConProduto();
                var nome = txtNome.Text;
                if (produto.RegistroRepetido(nome) == true)
                {
                    MessageBox.Show("Produto já existe em nossa base de dados!", "Produto repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Text = "";
                    txtValor.Text = "";
                    txtQuantidade.Text = "";
                    pbxFoto.Image = null;
                    pbxFoto.Update();
                    this.ActiveControl = txtNome;
                    return;
                }
                else
                {
                    string foto = txtNome.Text.Replace(" ", "");
                    pbxFoto.Image.Save(@"C:\Users\Aluno\Downloads\Nova pasta\loja geek gabriel\Fotos produtos" + foto + ".jpg");
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    string nome1 = txtNome.Text;
                    string valor = txtValor.Text;
                    produto.Inserir(nome, quantidade, valor, foto);
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Produto> produtos = produto.listaproduto();
                    dgvProduto.DataSource = produtos;
                    txtNome.Text = "";
                    txtValor.Text = "";
                    txtQuantidade.Text = "";
                    pbxFoto.Image = null;
                    pbxFoto.Update();
                    this.ActiveControl = txtNome;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
