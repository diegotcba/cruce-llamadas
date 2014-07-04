using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceLlamadas
{
    class CruceLlamadas
    {
        public DateTime Fecha { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }

        public Linea Origen { get; set; }
        public Linea Destino { get; set; }
        public Resultado Resultado { get; set; }

    }
}
