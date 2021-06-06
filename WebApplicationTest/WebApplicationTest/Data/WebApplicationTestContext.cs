using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest.Models;

namespace WebApplicationTest.Data
{
    public class WebApplicationTestContext : DbContext
    {
        public WebApplicationTestContext (DbContextOptions<WebApplicationTestContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationTest.Models.Student> Student { get; set; }
    }
}
