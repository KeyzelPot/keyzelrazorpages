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
    public class IndexModel : PageModel
    {
        private readonly keyzelrazorpages.Data.keyzelrazorpagesContext _context;

        public IndexModel(keyzelrazorpages.Data.keyzelrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Story> Story { get;set; }

        public async Task OnGetAsync()
        {
            Story = await _context.Story.ToListAsync();
        }
    }
}
