using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTL.Data;
using BTL.Models;
using BTL.Models.Process;
using OfficeOpenXml;
using X.PagedList;
using NuGet.Protocol;

namespace BTL.Controllers
{
    public class KhoHangController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KhoHangController(ApplicationDbContext context)
        {
            _context = context;
        }
         private ExcelProcess _excelPro = new ExcelProcess();

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
            var model = _context.KhoHang.ToList().ToPagedList(page ?? 1, pagesize);
            return View(model);
        }

        // GET: KhoHang

        // GET: KhoHang/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoHang = await _context.KhoHang
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (khoHang == null)
            {
                return NotFound();
            }

            return View(khoHang);
        }

        // GET: KhoHang/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhoHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSP,TenSP,GiaSP,SoLuongSP")] KhoHang khoHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khoHang);
        }

        // GET: KhoHang/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoHang = await _context.KhoHang.FindAsync(id);
            if (khoHang == null)
            {
                return NotFound();
            }
            return View(khoHang);
        }

        // POST: KhoHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaSP,TenSP,GiaSP,SoLuongSP")] KhoHang khoHang)
        {
            if (id != khoHang.MaSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoHangExists(khoHang.MaSP))
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
            return View(khoHang);
        }

        // GET: KhoHang/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoHang = await _context.KhoHang
                .FirstOrDefaultAsync(m => m.MaSP == id);
            if (khoHang == null)
            {
                return NotFound();
            }

            return View(khoHang);
        }

        // POST: KhoHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khoHang = await _context.KhoHang.FindAsync(id);
            if (khoHang != null)
            {
                _context.KhoHang.Remove(khoHang);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoHangExists(int id)
        {
            return _context.KhoHang.Any(e => e.MaSP == id);
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file!=null)
                {
                    string fileExtension = Path.GetExtension(file.FileName);
                    if (fileExtension != ".xls" && fileExtension != ".xlsx")
                    {
                        ModelState.AddModelError("", "Please choose excel file to upload!");
                    }
                    else
                    {
                        //rename file when upload to server
                        var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", "File" + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond + fileExtension);
                        var fileLocation = new FileInfo(filePath).ToString();
                        if (file.Length > 0)
                        {
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                //save file to server
                                await file.CopyToAsync(stream);
                                //read data from file and write to database
                                var dt = _excelPro.ExcelToDataTable(fileLocation);
                                for(int i = 0; i < dt.Rows.Count; i++)
                                {
                                    var kh = new KhoHang();
                                    kh.TenSP = dt.Rows[i][0].ToString();
                                    kh.GiaSP = dt.Rows[i][1].ToString();
                                    kh.SoLuongSP = (int)dt.Rows[i][2];

                                    _context.Add(kh);
                                }
                                await _context.SaveChangesAsync();
                                return RedirectToAction(nameof(Index));
                            }
                        }
                    }
                }

            return View();
        }

        // download
        public IActionResult Download()
        {
            var fileName = "KhoHangList.xlsx";
            using(ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
                excelWorksheet.Cells["A1"].Value = "TenSP";
                excelWorksheet.Cells["B1"].Value = "GiaSP";
                excelWorksheet.Cells["C1"].Value = "SoLuongSP";
                var KhoHangList = _context.KhoHang.ToList();
                excelWorksheet.Cells["A2"].LoadFromCollection(KhoHangList);
                var stream = new MemoryStream(excelPackage.GetAsByteArray());
                return File(stream,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
            }
        }

        private bool KhoHangExists(string id)
        {
            return _context.KhoHang.Any(e => e.TenSP == id);
       
        }
    }
}
