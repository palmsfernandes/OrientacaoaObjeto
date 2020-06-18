using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coisas
{
    class Moto : IAutomoveis
    {
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Peso { get; set; }
        public int Potencia { get; set; }

        public void Correr() { }
        public void Frear() { }
        public void Saltar() { }
        public void Desligar() { }
    }
}
