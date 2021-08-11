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
    public class IndexModel : PageModel
    {
        private readonly ToysWorld.Data.ToysWorldContext _context;

        public IndexModel(ToysWorld.Data.ToysWorldContext context)
        {
            _context = context;
        }

        public IList<Target> Target { get;set; }

        public async Task OnGetAsync()
        {
            Target = await _context.Target.ToListAsync();
        }
    }
}
