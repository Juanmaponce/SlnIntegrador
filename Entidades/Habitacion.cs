using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion()
        {
        }

        public Habitacion(string iD, int numero, string estado)
        {
            ID = iD;
            Numero = numero;
            Estado = estado;
        }

        public string ID { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
    }
}
