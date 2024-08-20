using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Persona
    {
        




        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }
        public void AsignarNombresCompletos () 
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
