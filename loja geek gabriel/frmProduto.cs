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
using System.Reflection;

namespace loja_geek_gabriel
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
            ConProduto conProduto = new ConProduto();
            List<Produto> produtos = conProduto.listaproduto();
            dgvProduto.DataSource = produtos;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            this.ActiveControl = txtNome;
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
            if (txtNome.Text == string.Empty || txtValor.Text == string.Empty || txtQuantidade.Text == string.Empty || pbxFoto.Image == null)
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
                    pbxFoto.Image.Save(@"C:\Users\Aluno\Desktop\tome\loja geek gabriel\fotos" + foto + ".jpg");
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtValor.Text == string.Empty || txtQuantidade.Text == string.Empty || pbxFoto.Image == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos do formulário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConProduto produto = new ConProduto();
            
            string nome = txtNome.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            string valor = txtValor.Text;
            string imagem = txtNome.Text.Replace(" ", "");
            int id = Convert.ToInt32(txtId.Text);
            pbxFoto.Image.Save(@"C:\Users\Aluno\Downloads\tome\loja geek gabriel\fotos" + imagem + ".jpg");
            
            produto.Atualizar(id,nome, quantidade, valor, imagem);
            MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Produto> produtos = produto.listaproduto();
            dgvProduto.DataSource = produtos;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            this.ActiveControl = txtNome;
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                this.dgvProduto.Rows[e.RowIndex].Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtQuantidade.Text = row.Cells[2].Value.ToString();
                txtValor.Text = row.Cells[3].Value.ToString();
            }
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ConProduto produto = new ConProduto();
            var id = Convert.ToInt32(txtId.Text);
            produto.Excluir(id);
            MessageBox.Show("Produto excluido!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Produto> produtos = produto.listaproduto();
            dgvProduto.DataSource = produtos;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
