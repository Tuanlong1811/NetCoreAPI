using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTL.Data;
using BTL.Models;
using OfficeOpenXml;
using X.PagedList;

namespace BTL.Controllers
{
    public class NhaCCController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NhaCCController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NhaCC
       

        public async Task<IActionResult> Index(int? page, int? PageSize)
        {
            ViewBag.PageSize = new List<SelectListItem>()
            {
                new SelectListItem() { Value="3", Text="3"},
                new SelectListItem() { Value="5", Text="5"},
                new SelectListItem() { Value="10", Text="10"},
                new SelectListItem() { Value="15", Text="15"},
                new SelectListItem() { Value="25", Text="25"},
                new SelectListItem() { Value="50", Text="50"},
            };
            int pagesize = (PageSize ?? 3);
            ViewBag.psize = pagesize;
            var model = _context.NhaCC.ToList().ToPagedList(page ?? 1, pagesize);
            return View(model);
        }

        // GET: NhaCC/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCC = await _context.NhaCC
                .FirstOrDefaultAsync(m => m.NhaCCID == id);
            if (nhaCC == null)
            {
                return NotFound();
            }

            return View(nhaCC);
        }

        // GET: NhaCC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhaCC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NhaCCID,TenNhaCC,TenSPCC,SoLuongCC,GiaThanh,DiaChi,Email")] NhaCC nhaCC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaCC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhaCC);
        }

        // GET: NhaCC/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCC = await _context.NhaCC.FindAsync(id);
            if (nhaCC == null)
            {
                return NotFound();
            }
            return View(nhaCC);
        }

        // POST: NhaCC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NhaCCID,TenNhaCC,TenSPCC,SoLuongCC,GiaThanh,DiaChi,Email")] NhaCC nhaCC)
        {
            if (id != nhaCC.NhaCCID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaCC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaCCExists(nhaCC.NhaCCID))
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
            return View(nhaCC);
        }

        // GET: NhaCC/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaCC = await _context.NhaCC
                .FirstOrDefaultAsync(m => m.NhaCCID == id);
            if (nhaCC == null)
            {
                return NotFound();
            }

            return View(nhaCC);
        }

        // POST: NhaCC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nhaCC = await _context.NhaCC.FindAsync(id);
            if (nhaCC != null)
            {
                _context.NhaCC.Remove(nhaCC);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhaCCExists(string id)
        {
            return _context.NhaCC.Any(e => e.NhaCCID == id);
        }
    }
}
