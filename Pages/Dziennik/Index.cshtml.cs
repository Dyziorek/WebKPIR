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
    public class IndexModel : PageModel
    {
        private readonly KsiegaContext _context;

        public IndexModel(KsiegaContext context)
        {
            _context = context;
        }

        public IList<WebKPIR.Model.Ksiega.Dziennik> Dziennik { get;set; }

        public async Task OnGetAsync()
        {
           // var testTable = _context.Dziennik.ToList();

            //Dziennik = await _context.Dziennik.ToListAsync();

            Dziennik = await _context.Dziennik
                .Include(d => d.KontoNavigation)
                .Include(d => d.NazwaSkrNavigation).ToListAsync();
        }
    }
}
