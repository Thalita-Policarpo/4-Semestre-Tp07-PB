using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4ºSemestre_Tp07_PB
{
    public class Professor
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matrícula: {Matricula}";
        }
    }
}
