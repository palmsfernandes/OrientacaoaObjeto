using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisas
{
    class Leao : IFelinos, ISeresVivos
    {
        public string Nome { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public int Velocidade { get; set; }

        public void Correr() { }
        public void Nadar() { }
        public void Dormir() { }
        public void Cacar() { }

        public void Comer()
        {
           
        }

        public void Respirar()
        {
           
        }
    }
}
