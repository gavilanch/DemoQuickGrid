using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemorGridESP.Shared
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Puntuacion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
