using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlEscolar.clases
{
    public static class ListaCarreras
    {
        public static List<Carrera> carreras = new List<Carrera>();

        public static int buscarCarrera(string nombre_corto)
        {
            for(int i=0; i < carreras.Count; i++)
            {
                if(nombre_corto == carreras[i].Nombre_corto)
                {
                    return i; 
                }
            }
            return -1;
        }
    }
}
