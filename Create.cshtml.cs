#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using keyzelrazorpages.Data;

namespace keyzelrazorpages.Pages.Story
{
    public class CreateModel : PageModel
    {
        private readonly keyzelrazorpages.Data.keyzelrazorpagesContext _context;

        public CreateModel(keyzelrazorpages.Data.keyzelrazorpagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Story Story { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Story.Add(Story);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
