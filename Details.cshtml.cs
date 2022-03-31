#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using keyzelrazorpages.Data;

namespace keyzelrazorpages.Pages.Story
{
    public class DetailsModel : PageModel
    {
        private readonly keyzelrazorpages.Data.keyzelrazorpagesContext _context;

        public DetailsModel(keyzelrazorpages.Data.keyzelrazorpagesContext context)
        {
            _context = context;
        }

        public Story Story { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Story = await _context.Story.FirstOrDefaultAsync(m => m.ID == id);

            if (Story == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
