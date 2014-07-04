using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruceLlamadas
{
    class Resultado
    {
        public List<ItemResultado> Detalle { get; set; }


        public void ordenarPorFecha()
        {
            this.Detalle = this.Detalle.OrderBy(s => s.fechahora).ToList();
        }
    }

}
