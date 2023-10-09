using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AzureApp_Razorpages.Web.Data;
using AzureApp_Razorpages.Web.Model;

namespace AzureApp_Razorpages.Web.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext _context;

        public CreateModel(AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Product == null || Product == null)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
