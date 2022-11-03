using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente: Persona
    {
        public Paciente()
        {
        }

        public Paciente(string nombre, string apellido, string domicilio, string telefono, string email, string iD, int nroHistoriaClinica) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            ID = iD;
            NroHistoriaClincica = nroHistoriaClinica;

        }

        public int NroHistoriaClincica { get; set; }
    }
}
