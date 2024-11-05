using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDTeste
{
    internal class Funcionario
    {
        public int Nome { get; set; }
        public Departamento departamento { get; set; }

        public Funcionario() { }

        public Funcionario( int nome, Departamento departamento)
        {
            Nome = nome;
            this.departamento = departamento;
        }
    }
}
