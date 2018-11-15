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
    public partial class fmAlumnoConsulta : Form
    {
        public fmAlumnoConsulta()
        {
            InitializeComponent();
        }

        private void fmAlumnoConsulta_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("No.Control", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellidos", typeof(string));
            table.Columns.Add("Carrera", typeof(string));
            table.Columns.Add("Genero", typeof(string));
            table.Columns.Add("Fecha Nacimiento", typeof(string));
            table.Columns.Add("Semestre", typeof(string));
            for(int i=0; i < ListaAlumnos.alumnos.Count; i++)
            {
                table.Rows.Add(ListaAlumnos.alumnos[i].NoControl,
                               ListaAlumnos.alumnos[i].Nombre,
                               ListaAlumnos.alumnos[i].Apellidos,
                               ListaAlumnos.alumnos[i].Carrera,
                               ListaAlumnos.alumnos[i].Genero,
                               ListaAlumnos.alumnos[i].Fnac,
                               ListaAlumnos.alumnos[i].Semestre);
            }
            dgvAlumnos.DataSource = table;

            /*                   
            var bindingList = new BindingList<Alumno>(ListaAlumnos.alumnos);
            var source = new BindingSource(bindingList, null);
            dgvAlumnos.DataSource = source;*/
        }

        private void Editar(object sender, EventArgs e)
        {

        }

        private void btAlumnoEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                int index = dgvAlumnos.CurrentCell.RowIndex;
                ListaAlumnos.alumnos.Remove(
                    ListaAlumnos.alumnos[index]
                    );
                dgvAlumnos.Rows.RemoveAt(index);
                MessageBox.Show("Registro eliminado");
            }
        }     
        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvAlumnos.CurrentCell.RowIndex;
            fmAlumnoNuevo fmAlumnoEditar = new fmAlumnoNuevo();
            fmAlumnoEditar.alumnoEditar = index;
            fmAlumnoEditar.Show();

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
