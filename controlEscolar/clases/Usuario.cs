using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlEscolar.clases
{
    public class Usuario
    {
        private string _noControl { get; set; }
        private string _nombre { get; set; }
        private string _apellidos { get; set; }
        private string _fnac { get; set; }
        private string _genero { get; set; }

        public string NoControl {
            get { return _noControl; }
            set { _noControl = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Fnac
        {
            get { return _fnac; }
            set { _fnac = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

    }
}
