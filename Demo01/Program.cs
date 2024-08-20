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
            /*Persona persona = new Persona
            {
                Nombres = "Ethan",
                Apellidos = "Arredondo"
            };
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);
            Console.Read();
            Profesor profesor = new Profesor
            {
                Nombres = "Hugo",
                Apellidos = "Torrico",
                Sueldo = 150000
            };
            Estudiante estudiante = new Estudiante
            {
                Nombres = "Sebastian",
                Apellidos = "Yarihuaman",
                codigoEstudiante = 115157
            };*/

            Coordenada coordenada1 = new Coordenada
            {
                CoordenadaX = 0,
                CoordenadaY = 0
            };
            Coordenada coordenada2 = new Coordenada
            {
                CoordenadaX = 4,
                CoordenadaY = 0
            };
            Coordenada coordenada3 = new Coordenada
            {
                CoordenadaX = 0,
                CoordenadaY = 8
            };
            Coordenada coordenada4 = new Coordenada
            {
                CoordenadaX = 4,
                CoordenadaY = 8
            };

            Rectangulo rectangulo = new Rectangulo
            {
                Coordenada1 = coordenada1,
                Coordenada2 = coordenada2,
                Coordenada3 = coordenada3,
                Coordenada4 = coordenada4,
            };
            rectangulo.CalcularAltura();
            rectangulo.CalcularBase();
            rectangulo.CalcularArea();
            rectangulo.CalcularPerimetro();

            Console.WriteLine("La altura es: ");
            Console.WriteLine(rectangulo.Altura);
            Console.WriteLine("La base es: ");
            Console.WriteLine(rectangulo.Base);
            Console.WriteLine("El área es: ");
            Console.WriteLine(rectangulo.Area); 
            Console.WriteLine("El perímetro es: ");
            Console.WriteLine(rectangulo.Perimetro);
            Console.Read();
        }
        static void Rectangulo()

        {
            /*Rectangulo rectangulo = new Rectangulo();
            rectangulo.Altura = 10;
            rectangulo.Base = 20;
            double perimetro = 0;
            double area = 0;

            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El área es: ");
            Console.WriteLine(area);
            Console.WriteLine("El perímetro es: ");
            Console.WriteLine(perimetro);*/
        }

    }
}
