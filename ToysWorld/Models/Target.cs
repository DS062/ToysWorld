using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysWorld.Models
{
    public class Target
    {

        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Target")]
        public string ETarget { get; set; }


        public Sales sales{ get; set; }
    }
}
