using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Mvcmovie.Controller
{
public class PersonController : Controller
{
    private readonly ApplicationDbcontext _context;

    public async Task<IActionResult> Index()

    public IActionResult Create()
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("PersonId,FullName,Address")] Person person)
    public async Task<IActionResult> Edit(string id)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id[Bind("PersonId,FullName,Address")] Person person)
    public async Task<IActionResult> Delte(string id)
     [HttpPost,ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(string id)
    private bool PersonExists(string id)
}
}