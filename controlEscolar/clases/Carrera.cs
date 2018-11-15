using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlEscolar.clases
{
    public class Carrera
    {
        private int _id { get; set; }
        private string _nombre { get; set; }
        private string _nombre_corto { get; set; }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Nombre_corto
        {
            get { return _nombre_corto; }
            set { _nombre_corto = value; }
        }
    }
}
