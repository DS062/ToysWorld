﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysWorld.Models
{
    public class Toys
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }



        [Display(Name = "Qty")]
        public int Qty { get; set; }



        [Display(Name = "Price")]
        public int Price { get; set; }


    }
}
