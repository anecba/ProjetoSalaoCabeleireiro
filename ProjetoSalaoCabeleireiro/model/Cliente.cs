using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalaoCabeleireiro.model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }
        public string Email { get; set; }
        public Boolean Ativo { get; set; }
        public int Celular { get; set; }
    }
}
