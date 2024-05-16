using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Librery_ProjectF.Data;
using Librery_ProjectF.Models;

namespace Librery_ProjectF.Views.Emply
{
    public class IndexModel : PageModel
    {
        private readonly Librery_ProjectF.Data.Librery_ProjectFContext _context;

        public IndexModel(Librery_ProjectF.Data.Librery_ProjectFContext context)
        {
            _context = context;
        }

        public IList<Employees> Employees { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employees = await _context.Employees.ToListAsync();
        }
    }
}
