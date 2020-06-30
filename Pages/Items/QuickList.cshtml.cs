using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BL3WebApp.Data;
using BL3WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BL3WebApp.Pages.Items
{
    public class QuickListModel : PageModel
    {
        private readonly BL3WebApp.Data.BL3WebAppContext _context;

        public QuickListModel(BL3WebApp.Data.BL3WebAppContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Types { get; set; }

        [BindProperty(SupportsGet = true)]
        public string ItemType { get; set; }

        public async Task OnGetAsync()
        {
            var items = from i in _context.Item
                        select i;

            if (!string.IsNullOrEmpty(SearchString))
            {
                items = items.Where(s => s.Name.Contains(SearchString));
            }

            Item = await items.ToListAsync();
        }
    }
}
