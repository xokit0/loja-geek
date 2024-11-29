using loja_geek_gabriel.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_geek_gabriel
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == string.Empty || txtNome.Text == string.Empty || cbxFuncao == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos do formulário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ConPerfil perfil = new ConPerfil();
                string cpf = txtCpf.Text;
                perfil.Localizar(cpf);
                if (cpf == perfil.CPF && txtNome.Text == perfil.nome && cbxFuncao.SelectedIndex == perfil.funcao)
                {
                    MessageBox.Show("Login efetuado!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var funcao = perfil.funcao;
                    txtCpf.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    cbxFuncao.SelectedIndex = 0;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == string.Empty || txtNome.Text == string.Empty || cbxFuncao == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos do formulário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ConPerfil perfil = new ConPerfil();
                string cpf = txtCpf.Text;
                if(perfil.RegistroRepetito(cpf) == true)
                {
                    MessageBox.Show("Este CPF ja existe em nosso banco de dados!", "Perfil repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string nome = txtNome.Text;
                    int funcao = cbxFuncao.SelectedIndex;
                    perfil.Registrar(nome, cpf, funcao);
                    MessageBox.Show("Registro realizado!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpf.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    cbxFuncao.SelectedIndex = 0;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
