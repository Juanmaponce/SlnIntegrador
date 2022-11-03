using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clinica
    {
        public Clinica()
        {
        }

        public Clinica(string iD, string nombre, string domicilio, string telefono, string email)
        {
            ID = iD;
            Nombre = nombre;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }

        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
