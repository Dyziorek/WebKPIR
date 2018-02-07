using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebKPIR.Model.Ksiega;

namespace WebKPIR.Pages.Dziennik
{
    public class CreateModel : PageModel
    {
        private readonly KsiegaContext _context;

        public CreateModel(KsiegaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto");
        ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip");
            return Page();
        }

        [BindProperty]
        public WebKPIR.Model.Ksiega.Dziennik Dziennik { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dziennik.Add(Dziennik);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}