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
    public class DeleteModel : PageModel
    {
        private readonly Librery_ProjectF.Data.Librery_ProjectFContext _context;

        public DeleteModel(Librery_ProjectF.Data.Librery_ProjectFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employees Employees { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FirstOrDefaultAsync(m => m.Id == id);

            if (employees == null)
            {
                return NotFound();
            }
            else
            {
                Employees = employees;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employees = await _context.Employees.FindAsync(id);
            if (employees != null)
            {
                Employees = employees;
                _context.Employees.Remove(Employees);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
