using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactApplication.Data;
using ContactApplication.Models;

namespace ContactApplication.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ContactApplication.Data.ContactApplicationContext _context;

        public IndexModel(ContactApplication.Data.ContactApplicationContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact.ToListAsync();
            }
        }
    }
}
