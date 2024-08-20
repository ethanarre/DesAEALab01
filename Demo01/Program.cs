using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona
            {
                Nombres = "Ethan",
                Apellidos = "Arredondo"
            };
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);
            Console.Read();
            Rectangulo();
        }
        static void Rectangulo()
        {
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Altura = 10;
            rectangulo.Base = 20;
            double perimetro = 0;
            double area = 0;

            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El área es: ");
            Console.WriteLine(area);
            Console.WriteLine("El perímetro es: ");
            Console.WriteLine(perimetro);
        }

    }
}
