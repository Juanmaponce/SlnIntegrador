using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico : Persona
    {
        public Medico()
        {
        }

        public Medico(string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, string iD, int matricula) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            ID = iD;
            Especialidad = especialidad;
            Matricula = matricula;
        }


        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }
}
