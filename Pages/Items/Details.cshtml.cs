using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BL3WebApp.Data;
using BL3WebApp.Models;

namespace BL3WebApp.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly BL3WebApp.Data.BL3WebAppContext _context;

        public DetailsModel(BL3WebApp.Data.BL3WebAppContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.ID == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
