using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
   public class MetasDetalle
    {

        [Key]
        public int MetaID { get; set; }
        public String Descripcion { get; set; }
        public float Cuotas { get; set; }


        public MetasDetalle(int metaid)
        {
            MetaID = 0;
            Descripcion = string.Empty;
            Cuotas = 0;
        }

       public MetasDetalle(int metaid, float cuotas,string descripcion)
        {
            MetaID = metaid;
            Cuotas = cuotas;
            Descripcion = descripcion;
        }
    }
}
