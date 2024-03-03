using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final
{
    public class Clase_Docentes
    {
        public int id_personas { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public string materia { get; set; }

        public Clase_Docentes()
        {
        }
        public Clase_Docentes(int id_personas, string nombre, string apellido, int dNI, string materia)
        {
            this.id_personas = id_personas;
            this.nombre = nombre;
            this.apellido = apellido;
            DNI = dNI;
            this.materia = materia;
        }

        
    }
}
