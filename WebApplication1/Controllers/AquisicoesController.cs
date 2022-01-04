#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AquisicoesController : Controller
    {
        private readonly DatabaseContext _context;

        public AquisicoesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Aquisicoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.adquirido.ToListAsync());
        }

        // GET: Aquisicoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aquisicoes = await _context.adquirido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aquisicoes == null)
            {
                return NotFound();
            }

            return View(aquisicoes);
        }

        // GET: Aquisicoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aquisicoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdViagem,IdCliente,Quantidade,DataCheckin,DataCheckOut")] Aquisicoes aquisicoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aquisicoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aquisicoes);
        }

        // GET: Aquisicoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aquisicoes = await _context.adquirido.FindAsync(id);
            if (aquisicoes == null)
            {
                return NotFound();
            }
            return View(aquisicoes);
        }

        // POST: Aquisicoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdViagem,IdCliente,Quantidade,DataCheckin,DataCheckOut")] Aquisicoes aquisicoes)
        {
            if (id != aquisicoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aquisicoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AquisicoesExists(aquisicoes.Id))
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
            return View(aquisicoes);
        }

        // GET: Aquisicoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aquisicoes = await _context.adquirido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aquisicoes == null)
            {
                return NotFound();
            }

            return View(aquisicoes);
        }

        // POST: Aquisicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aquisicoes = await _context.adquirido.FindAsync(id);
            _context.adquirido.Remove(aquisicoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AquisicoesExists(int id)
        {
            return _context.adquirido.Any(e => e.Id == id);
        }
    }
}
