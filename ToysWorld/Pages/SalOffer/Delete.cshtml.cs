using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToysWorld.Data;
using ToysWorld.Models;

namespace ToysWorld.Pages.SalOffer
{
    public class DeleteModel : PageModel
    {
        private readonly ToysWorld.Data.ToysWorldContext _context;

        public DeleteModel(ToysWorld.Data.ToysWorldContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Offers Offers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Offers = await _context.Offers.FirstOrDefaultAsync(m => m.id == id);

            if (Offers == null)
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

            Offers = await _context.Offers.FindAsync(id);

            if (Offers != null)
            {
                _context.Offers.Remove(Offers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
