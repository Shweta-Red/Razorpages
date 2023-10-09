using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureApp_Razorpages.Web.Model;

namespace AzureApp_Razorpages.Web.Data
{
    public class AzureApp_RazorpagesWebContext : DbContext
    {
        public AzureApp_RazorpagesWebContext (DbContextOptions<AzureApp_RazorpagesWebContext> options)
            : base(options)
        {
        }

        public DbSet<AzureApp_Razorpages.Web.Model.Product> Product { get; set; } = default!;
    }
}
