using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Rectangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }
        public double Perimetro { get; set; }
        public double Area { get; set; }
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }

        public Coordenada Coordenada1 { get; set; }
        public Coordenada Coordenada2 { get; set; }
        public Coordenada Coordenada3 { get; set; }
        public Coordenada Coordenada4 { get; set; }

        public void CalcularBase()
        {
            double x1 = 0;
            double x2 = 0;
            double y1 = 0;
            double y2 = 0;
            x1 = Coordenada1.CoordenadaX;
            x2 = Coordenada2.CoordenadaX;
            y1 = Coordenada1.CoordenadaY;
            y2 = Coordenada2.CoordenadaY;

            Base = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
        }
        public void CalcularAltura()
        {
            double x1 = 0;
            double x3 = 0;
            double y1 = 0;
            double y3 = 0;
            x1 = Coordenada1.CoordenadaX;
            x3 = Coordenada3.CoordenadaX;
            y1 = Coordenada1.CoordenadaY;
            y3 = Coordenada3.CoordenadaY;

            Altura = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
        }
        public void CalcularArea()
        {
            Area = Altura * Base;
        }
        public void CalcularPerimetro()
        {
            Perimetro = Altura * 2 + Base * 2;
        }
    }
}
