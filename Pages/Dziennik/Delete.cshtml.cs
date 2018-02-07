using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebKPIR.Model.Ksiega;

namespace WebKPIR.Pages.Dziennik
{
    public class DeleteModel : PageModel
    {
        private readonly KsiegaContext _context;

        public DeleteModel(KsiegaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WebKPIR.Model.Ksiega.Dziennik Dziennik { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dziennik = await _context.Dziennik
                .Include(d => d.KontoNavigation)
                .Include(d => d.NazwaSkrNavigation).SingleOrDefaultAsync(m => m.Numer == id);

            if (Dziennik == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dziennik = await _context.Dziennik.FindAsync(id);

            if (Dziennik != null)
            {
                _context.Dziennik.Remove(Dziennik);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
