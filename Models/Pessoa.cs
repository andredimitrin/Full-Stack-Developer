using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Full_Stack_Developer.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            // Console.WriteLine($"Olá, meu nome é {Nome}\nE tenho {Idade} anos");
        }
    }
}