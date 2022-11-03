using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero : Persona
    {
        public Enfermero()
        {
        }

        public Enfermero(string iD,string nombre, string apellido, string domicilio, string telefono, string email, int cUIL) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            CUIL = cUIL;
        }

        public int CUIL { get; set; }
    }
}
