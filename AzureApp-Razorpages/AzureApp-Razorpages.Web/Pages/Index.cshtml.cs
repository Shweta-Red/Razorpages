using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureApp_Razorpages.Web.Data;
using AzureApp_Razorpages.Web.Model;

namespace AzureApp_Razorpages.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext _context;

        public IndexModel(AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
