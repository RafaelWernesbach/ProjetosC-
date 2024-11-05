using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTeste
{
    internal class Departamento
    {
        public string Nome { get; set; }
        public List<Funcionario>? funcionarios { get; set; }

        public Departamento() { }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
