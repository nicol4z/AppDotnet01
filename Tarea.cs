using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotnet01
{
    public class Tarea
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDTarea { get; set; }

        public string estado { get; set; }

        public string avance { get; set; }

        public int IDProyecto { get; set; }

        [ForeignKey("IDProyecto")]
        public virtual Proyecto proyecto { get; set; }
    }
}
