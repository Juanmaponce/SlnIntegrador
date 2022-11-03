using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director : Medico
    {
        public Director()
        {
        }

        public Director(string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, string iD, int matricula) : base(nombre, apellido, domicilio, telefono, email, especialidad, iD, matricula)
        {
        }

        public string Posgrado { get; set; }
    }
}
