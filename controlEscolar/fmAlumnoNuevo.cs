using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlEscolar.clases;

namespace controlEscolar
{
    public partial class fmAlumnoNuevo : Form
    {
        public int alumnoEditar = -1;

        public fmAlumnoNuevo()
        {
            InitializeComponent();
        }
        private void fmAlumnoNuevo_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < ListaCarreras.carreras.Count; i++)
            {
                cbCarrera.Items.Add(ListaCarreras.carreras[i].Nombre);
            }
            for (int i = 1; i <= 14; i++)
            {
                cbSem.Items.Add(i);
            }

            if (alumnoEditar >= 0)
            {
                tbNoControl.Text = ListaAlumnos.alumnos[alumnoEditar].NoControl;
                tbNombre.Text = ListaAlumnos.alumnos[alumnoEditar].Nombre;
                tbApellidos.Text = ListaAlumnos.alumnos[alumnoEditar].Apellidos;
                int posCarrera = ListaCarreras.buscarCarrera(ListaAlumnos.alumnos[alumnoEditar].Carrera);
                cbCarrera.SelectedIndex = posCarrera;
                if(ListaAlumnos.alumnos[alumnoEditar].Genero == "H")
                {
                    rbGeneroH.Checked = true;
                }
                else
                {
                    rbGeneroM.Checked = true;
                }
                cbSem.SelectedIndex = (ListaAlumnos.alumnos[alumnoEditar].Semestre -1);
            }
        }
        

        private void btAlumnoGuardar_Click(object sender, EventArgs e)
        {
            if (alumnoEditar >= 0)
            {
                ListaAlumnos.alumnos[alumnoEditar].NoControl = tbNoControl.Text;
                ListaAlumnos.alumnos[alumnoEditar].Nombre = tbApellidos.Text;
                ListaAlumnos.alumnos[alumnoEditar].Apellidos = tbApellidos.Text;

            }
            else
            {
                Alumno alumno_tem = new Alumno();
                alumno_tem.NoControl = tbNoControl.Text;
                alumno_tem.Nombre = tbNombre.Text;
                alumno_tem.Apellidos = tbApellidos.Text;
                ListaAlumnos.alumnos.Add(alumno_tem);

            }
        }
    }
}
