using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
   public class Metas
    {
        public int MetaID { get; set; }
        public String Descripcion { get; set; }
        public decimal Cuotas { get; set; }


        public Metas()
        {
            MetaID = 0;
            Descripcion = string.Empty;
            Cuotas = 0;
        }

    }
}
