using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HPCTechnicalWebStore.Data;
using HPCTechnicalWebStore.Models;

namespace HPCTechnicalWebStore.Views
{
    public class IndexModel : PageModel
    {
        private readonly HPCTechnicalWebStore.Data.StoreContext _context;

        public IndexModel(HPCTechnicalWebStore.Data.StoreContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customer = await _context.Customers.ToListAsync();
            }
        }
    }
}
