using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebKPIR.Model.Ksiega;

namespace WebKPIR.Pages.Ksiega.Dziennik
{
    public class DziennikController : Controller
    {
        private readonly KsiegaContext _context;

        public DziennikController(KsiegaContext context)
        {
            _context = context;
        }

        // GET: Dziennik
        public async Task<IActionResult> Index()
        {
            var ksiegaContext = _context.Dziennik.Include(d => d.KontoNavigation).Include(d => d.NazwaSkrNavigation);
            return View(await ksiegaContext.ToListAsync());
        }

        // GET: Dziennik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dziennik = await _context.Dziennik
                .Include(d => d.KontoNavigation)
                .Include(d => d.NazwaSkrNavigation)
                .SingleOrDefaultAsync(m => m.Numer == id);
            if (dziennik == null)
            {
                return NotFound();
            }

            return View(dziennik);
        }

        // GET: Dziennik/Create
        public IActionResult Create()
        {
            ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto");
            ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip");
            return View();
        }

        // POST: Dziennik/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Konto,Ksiega,Struktura,NazwaSkr,NumerDok,Data,Dzien,Opis,Rejestr,Netto22,Vat22,Netto12,Vat12,Netto07,Vat07,Netto03,Vat03,Netto0,Nettozwol,Bezodl,VatBezodl,TypBezodl,NettoNp,Brutto,DataOtrz,MiesVat,MiesKs,Korekta,Uwagi,Samochod,NumerRej,Eksport,Notatki,NajemTyp,RozlTyp,FormaP,TerminP,WartoscZ,Numer,Kasa,TypFakt,Nip,NipKod,OpdKod,NrEwid,NazwaUsl,Rok")] WebKPIR.Model.Ksiega.Dziennik dziennik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dziennik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto", dziennik.Konto);
            ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip", dziennik.Nip);
            return View(dziennik);
        }

        // GET: Dziennik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dziennik = await _context.Dziennik.SingleOrDefaultAsync(m => m.Numer == id);
            if (dziennik == null)
            {
                return NotFound();
            }
            ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto", dziennik.Konto);
            ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip", dziennik.Nip);
            return View(dziennik);
        }

        // POST: Dziennik/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Konto,Ksiega,Struktura,NazwaSkr,NumerDok,Data,Dzien,Opis,Rejestr,Netto22,Vat22,Netto12,Vat12,Netto07,Vat07,Netto03,Vat03,Netto0,Nettozwol,Bezodl,VatBezodl,TypBezodl,NettoNp,Brutto,DataOtrz,MiesVat,MiesKs,Korekta,Uwagi,Samochod,NumerRej,Eksport,Notatki,NajemTyp,RozlTyp,FormaP,TerminP,WartoscZ,Numer,Kasa,TypFakt,Nip,NipKod,OpdKod,NrEwid,NazwaUsl,Rok")] WebKPIR.Model.Ksiega.Dziennik dziennik)
        {
            if (id != dziennik.Numer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dziennik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DziennikExists(dziennik.Numer))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Konto"] = new SelectList(_context.Set<Konta>(), "Konto", "Konto", dziennik.Konto);
            ViewData["Nip"] = new SelectList(_context.Set<Klient>(), "Nip", "Nip", dziennik.Nip);
            return View(dziennik);
        }

        // GET: Dziennik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dziennik = await _context.Dziennik
                .Include(d => d.KontoNavigation)
                .Include(d => d.NazwaSkrNavigation)
                .SingleOrDefaultAsync(m => m.Numer == id);
            if (dziennik == null)
            {
                return NotFound();
            }

            return View(dziennik);
        }

        // POST: Dziennik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dziennik = await _context.Dziennik.SingleOrDefaultAsync(m => m.Numer == id);
            _context.Dziennik.Remove(dziennik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DziennikExists(int id)
        {
            return _context.Dziennik.Any(e => e.Numer == id);
        }
    }
}
