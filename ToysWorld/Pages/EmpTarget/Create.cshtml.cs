﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToysWorld.Data;
using ToysWorld.Models;

namespace ToysWorld.Pages.EmpTarget
{
    public class CreateModel : PageModel
    {
        private readonly ToysWorld.Data.ToysWorldContext _context;

        public CreateModel(ToysWorld.Data.ToysWorldContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Target Target { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Target.Add(Target);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
