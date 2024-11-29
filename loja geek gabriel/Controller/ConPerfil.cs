using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loja_geek_gabriel.Models;

namespace loja_geek_gabriel.Controller
{
    public class ConPerfil
    {

        public string nome { get; set; }
        public string CPF { get; set; }
        public int funcao { get; set; }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aluno\\Downloads\\tome\\loja geek gabriel\\DbGabriel.mdf\";Integrated Security=True");
        Perfil perfil = new Perfil();

        public void Registrar(string nome, string CPF, int funcao)
        {
            try
            {
                string sql = "INSERT INTO perfil(nome,CPF,funcao) VALUES ('" + nome + "', '" + CPF + "', '" + funcao + "')";
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public bool RegistroRepetito(string CPF)
        {
            string sql = "SELECT * FROM perfil WHERE CPF = '" + CPF + "'";
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

        public void Localizar(string cpf)
        {
            string sql = "SELECT * FROM perfil WHERE CPF = '" + cpf + "' ";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                CPF = (string)dr["CPF"];
                funcao = (int)dr["funcao"];
            }
            dr.Close();
            con.Close();
        }
    }
}
