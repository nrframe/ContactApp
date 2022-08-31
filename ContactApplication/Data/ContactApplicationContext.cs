using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactApplication.Models;

namespace ContactApplication.Data
{
    public class ContactApplicationContext : DbContext
    {
        public ContactApplicationContext (DbContextOptions<ContactApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ContactApplication.Models.Contact> Contact { get; set; } = default!;
    }
}
