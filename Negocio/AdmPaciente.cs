using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Nombre = "Fran", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com", ID = "PC3245",  NroHistoriaClincica = 3049 });
            pacientes.Add(new Paciente() { Nombre = "Pepe", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com", ID = "PC3246", NroHistoriaClincica = 3059 });
            pacientes.Add(new Paciente() { Nombre = "Juan", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com", ID = "PC3247", NroHistoriaClincica = 3069 });
            pacientes.Add(new Paciente() { Nombre = "Dani", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com", ID = "PC3248", NroHistoriaClincica = 3079 });
            pacientes.Add(new Paciente() { Nombre = "Julio", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",  ID = "PC3249", NroHistoriaClincica = 3089 });

            //TODO
            return pacientes;
        }
        public static List<Paciente> ListarEspecialicac(string especieladad)
        {
            //TODO
            return null;
        }
        public static int InsertarMedico(Paciente paciente)
        {
            //TODO    
            return 0;
        }

        public static int Eliminar(string id)
        {
            //TODO
            return 0;
        }
        public static int TraerUno(string id)
        {
            //TODO
            return 0;
        }
    }
}
