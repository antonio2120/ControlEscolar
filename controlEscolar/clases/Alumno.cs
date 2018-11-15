using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlEscolar.clases
{
    public class Alumno:Usuario
    {
        private string _carrera { get; set; }
        private int _semestre { get; set; }

        public string Carrera
        {
            get { return _carrera; }
            set { _carrera = value; }
        }
        public int Semestre
        {
            get { return _semestre; }
            set { _semestre = value; }
        }
    }
}
