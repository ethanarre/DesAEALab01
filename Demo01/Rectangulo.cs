using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Rectangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public double CalcularArea()
        {
            return Base * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
