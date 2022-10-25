using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotnet01
{
    public class ConsumoMaterial
    {
        [Key]
        public int idConsumo { get; set; }

        public DateTime Fecha { get; set; }

        public int Cantidad { get; set; }

        public int IDTarea { get; set; }

        public int IDMaterial { get; set; }

        [ForeignKey("IDTarea")]
        public virtual Tarea tarea { get; set; }

        [ForeignKey("IDMaterial")]
        public virtual Material material { get; set; }
    }
}
