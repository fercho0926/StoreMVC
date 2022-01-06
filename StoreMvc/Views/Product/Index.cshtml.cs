using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StoreMvc.Models;
using StoreMvc.Repository;

namespace StoreMvc.Views.Product
{
    public class IndexModel : PageModel
    {
        private readonly StoreMvc.Repository.DbStoreDbContext _context;

        public IndexModel(StoreMvc.Repository.DbStoreDbContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
