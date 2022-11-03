using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            List<Medico> medicos;

            //AdmMedico admMedico = new AdmMedico();

            medicos = AdmMedico.Listar();



            dataMedicoYPacientes.DataSource = medicos ;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes;

            //AdmPaciente admPaciente = new AdmPaciente();

            pacientes = AdmPaciente.Listar();
            dataMedicoYPacientes.DataSource = pacientes;
        }

        private void btnClinicos_Click(object sender, EventArgs e)
        {

            List<Medico> medicos;

            //AdmMedico admMedico = new AdmMedico();

            medicos = AdmMedico.Listar();

            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == "Clinico")
                {

                listBox1.Items.Add(medico.Nombre + " " + medico.Apellido);
                }
            }
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitaciones;

           // AdmHabitacion admHabitacion = new AdmHabitacion();

            habitaciones = AdmHabitacion.Listar();

            foreach (Habitacion habitacion in habitaciones)
            {


                    listBox1.Items.Add("Habitacion: " + habitacion.Numero + ", " + habitacion.Estado);
             
            }
        }
    }
}

