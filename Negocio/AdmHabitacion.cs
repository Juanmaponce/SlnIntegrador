using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {

        public static List<Habitacion> habitaciones;
        public static List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();

            habitaciones.Add(new Habitacion() { ID = "hb1", Numero = 1,Estado = "ocupada" });
            habitaciones.Add(new Habitacion() { ID = "hb2", Numero = 2,Estado = "desocupada" });
            habitaciones.Add(new Habitacion() { ID = "hb3", Numero = 3,Estado = "ocupada" });
            habitaciones.Add(new Habitacion() { ID = "hb4", Numero = 4,Estado = "desocupada" });
            habitaciones.Add(new Habitacion() { ID = "hb6", Numero = 5,Estado = "ocupada" });

            //TODO
            return habitaciones;
        }
        public static List<Habitacion> ListarEspecialicac(string especialidad)
        {
            //TODO
            return null;
        }
        public static int InsertarMedico(Habitacion habitacion)
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
