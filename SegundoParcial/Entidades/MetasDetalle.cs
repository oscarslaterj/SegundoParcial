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
        public decimal Cuotas { get; set; }


        public MetasDetalle()
        {
            MetaID = 0;
            Descripcion = string.Empty;
            Cuotas = 0;
        }

       
        public MetasDetalle(int v, int idMeta, string nombres, decimal cuotas, string descripcion)
        {
            Cuotas = cuotas;
            Descripcion = descripcion;
            
        }
    }
}
