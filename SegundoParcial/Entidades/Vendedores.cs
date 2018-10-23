using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Entidades
{
    public class Vendedores
    {
        [Key]

        public int VendedorId { get; set; }
        public String Nombres { get; set; }
        public decimal Cuota { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<MetasDetalle> metas { get; set; }

        public Vendedores()
        {
            VendedorId = 0;
            Nombres = string.Empty;
            Cuota = 0;
            Fecha = DateTime.Now;
            metas = new List<MetasDetalle>();
        }

    }
}
