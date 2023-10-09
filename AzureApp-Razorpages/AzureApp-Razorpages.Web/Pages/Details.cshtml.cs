﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext _context;

        public DetailsModel(AzureApp_Razorpages.Web.Data.AzureApp_RazorpagesWebContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
