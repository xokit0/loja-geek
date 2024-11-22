using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_geek_gabriel.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string imagem { get; set;}
        public decimal valor { get; set;}
        public int quantidade { get; set; }
    }
}
