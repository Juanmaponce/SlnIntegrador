using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public static class AdmMedico
    {

        public static List<Medico> medicos;

        public static List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Nombre = "Fran", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",Especialidad = "Cirujano plastico",ID = "MD3245",Matricula = 3049 });
            medicos.Add(new Medico() { Nombre = "Pepe", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",Especialidad = "Clinico",ID = "MD3246",Matricula = 3059 });
            medicos.Add(new Medico() { Nombre = "Juan", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",Especialidad = "Cirujano plastico",ID = "MD3247",Matricula = 3069 });
            medicos.Add(new Medico() { Nombre = "Dani", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",Especialidad = "Clinico",ID = "MD3248",Matricula = 3079 });
            medicos.Add(new Medico() { Nombre = "Julio", Apellido = "Roig", Domicilio = "Guaymallen", Telefono = "+549261595656", Email = "franroig@medico.com",Especialidad = "Cirujano plastico",ID = "MD3249",Matricula = 3089 });

            //TODO
            return medicos;
        }        
        public static List<Medico> ListarEspecialicac(string especialidad)
        {
            //TODO
            return null;
        }
        public static int InsertarMedico(Medico medico) { 
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
