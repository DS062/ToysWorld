using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysWorld.Models
{
    public class Offers
    {
        public int id { get; set; }

        [Display(Name = "Product")]
        public string Name { get; set; }


        [Display(Name = "Offers")]
        public string Doffers { get; set; }

        [Display(Name = "Valid Up to")]
        public DateTime vlid { get; set; }


        public Toys toys { get; set; }
    }
}
