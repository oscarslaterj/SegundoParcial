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
        public decimal Sueldo { get; set; }
        public string Cuota { get; set; }
        public DateTime Fecha { get; set; }

        public virtual List<Metas> metas{ get; set; }

        public Vendedores()
        {
            VendedorId = 0;
            Nombres = string.Empty;
            Sueldo = 0;
            Cuota = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
