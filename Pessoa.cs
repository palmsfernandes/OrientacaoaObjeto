using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisas
{
    class Pessoa : ISeresVivos
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }

        public void Correr() { }
        public void Falar() { }
        public void Pular() { }
        public void Nadar() { }

        public void Dormir()
        {
            
        }

        public void Comer()
        {
            
        }

        public void Respirar()
        {
            
        }
    }
}
