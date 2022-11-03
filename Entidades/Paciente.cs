using Entidades.Ayudantes;
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

        public Paciente(string nombre, string apellido, string domicilio, string telefono, string email, string iD, int nroHistoriaClinica, DateTime fechaNacimiento) : base(iD, nombre, apellido, domicilio, telefono, email)
        {
            ID = iD;
            NroHistoriaClincica = nroHistoriaClinica;
            FechaNacimiento = fechaNacimiento;
        }

        public int NroHistoriaClincica { get; set; }

        public DateTime FechaNacimiento { get; set; }

        private int edad;

        public int Edad
        {
            get {
                edad = UtilidadesFechas.CalcularEdad(FechaNacimiento);
                return edad; 
            }

        }

    }
}
