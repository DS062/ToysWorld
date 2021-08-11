using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToysWorld.Data;
using ToysWorld.Models;

namespace ToysWorld.Pages.KidToys
{
    public class DeleteModel : PageModel
    {
        private readonly ToysWorld.Data.ToysWorldContext _context;

        public DeleteModel(ToysWorld.Data.ToysWorldContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Toys Toys { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Toys = await _context.Toys.FirstOrDefaultAsync(m => m.id == id);

            if (Toys == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Toys = await _context.Toys.FindAsync(id);

            if (Toys != null)
            {
                _context.Toys.Remove(Toys);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
