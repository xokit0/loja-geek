using loja_geek_gabriel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_geek_gabriel.Controller
{
    public class ConProduto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string imagem { get; set; }
        public decimal valor { get; set; }
        public int quantidade { get; set; }

        
        //conectando com a base
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Aluno\\Downloads\\Nova pasta\\loja geek gabriel\\DbGabriel.mdf;Integrated Security = True");

        //instanciando o model produto
        Produto produto = new Produto();

        public List<Produto> listaproduto()
        {
            List<Produto> li = new List<Produto>();
            string sql = "SELECT * FROM produto";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto();
                produto.Id = (int)dr["Id"];
                produto.nome = dr["nome"].ToString();
                produto.quantidade = (int)dr["quantidade"];
                produto.valor = (decimal)dr["valor"];
                produto.imagem = dr["imagem"].ToString();
                li.Add(produto);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public bool RegistroRepetido(string nome)
        {
            string sql = "SELECT * FROM produto WHERE nome='" + nome + "'";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }

        public void Inserir(string nome, int quantidade, string valor, string imagem)
        {
            try
            {
                decimal valorreal = Convert.ToDecimal(valor) / 100;
                var quantidade1 = Convert.ToInt32(quantidade);
                string sql = "INSERT INTO produto(nome,valor,imagem,quantidade) VALUES ('" + nome + "',@valor,'" + imagem +"','" + quantidade1 + "')";
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = valorreal;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
