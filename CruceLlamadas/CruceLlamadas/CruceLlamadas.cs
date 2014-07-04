using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceLlamadas
{
    class CruceLlamadas
    {
        private DateTime Fecha { get; set; }
        private String Titulo { get; set; }
        private String Descripcion { get; set; }

        private Linea Origen { get; set; }
        private Linea Destino { get; set; }
        private Resultado Resultado { get; set; }

    }
}
