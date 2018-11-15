using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using controlEscolar.clases;

namespace controlEscolar
{
    public partial class fmPrincipal : Form
    {
        
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAlumnoNuevo formAlumno = new fmAlumnoNuevo();
            formAlumno.Show();
        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\carreras.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Carrera carrera_nuevo = new Carrera();
                    carrera_nuevo.Id = Convert.ToInt32(values[0]);
                    carrera_nuevo.Nombre = values[1];
                    carrera_nuevo.Nombre_corto = values[2];                   
                    ListaCarreras.carreras.Add(carrera_nuevo);
                }
            }
            using (var reader = new StreamReader(@"C:\alumnos.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Alumno alumno_nuevo = new Alumno();
                    alumno_nuevo.NoControl = values[0];
                    alumno_nuevo.Nombre = values[1];
                    alumno_nuevo.Apellidos = values[2];
                    alumno_nuevo.Carrera = values[3];
                    alumno_nuevo.Genero = values[4];
                    alumno_nuevo.Fnac = values[11];
                    alumno_nuevo.Semestre =Convert.ToInt32(values[10]);
                    ListaAlumnos.alumnos.Add(alumno_nuevo);                    
                }
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAlumnoConsulta formAlumnoConsulta = new fmAlumnoConsulta();
            formAlumnoConsulta.Show();
        }
    }
}
