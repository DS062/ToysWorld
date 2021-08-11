using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToysWorld.Data;
using ToysWorld.Models;

namespace ToysWorld.Pages.EmpTarget
{
    public class DetailsModel : PageModel
    {
        private readonly ToysWorld.Data.ToysWorldContext _context;

        public DetailsModel(ToysWorld.Data.ToysWorldContext context)
        {
            _context = context;
        }

        public Target Target { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Target = await _context.Target.FirstOrDefaultAsync(m => m.id == id);

            if (Target == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
