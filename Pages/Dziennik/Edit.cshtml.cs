using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKPIR.Model.Ksiega;

namespace WebKPIR.Pages.Dziennik
{
    public class EditModel : PageModel
    {
        private readonly KsiegaContext _context;

        public EditModel(KsiegaContext context)
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
           ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto");
           ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dziennik).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DziennikExists(Dziennik.Numer))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DziennikExists(int id)
        {
            return _context.Dziennik.Any(e => e.Numer == id);
        }
    }
}
