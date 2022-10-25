﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDotnet01
{
    public class Material
    {
        [Key]
        public int codigo { get; set; }

        public string nombre { get; set; }

        public int precio { get; set; }
    }
}
