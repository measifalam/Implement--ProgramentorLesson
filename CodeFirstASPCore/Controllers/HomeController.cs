using CodeFirstASPCore.Data;
using CodeFirstASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeFirstASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _studDb;

        public HomeController(ApplicationDbContext studDb)
        {
           _studDb = studDb;
        }

        public async Task<IActionResult> Index()
        {
            var stdData = await _studDb.Students.ToListAsync();
            return View(stdData);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Insert(Student std)
        {
           await _studDb.Students.AddAsync(std);
         await   _studDb.SaveChangesAsync();
            TempData["insert success"] = "Inserted...";
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Details(int id,Student std)
        {
            var studData = await _studDb.Students.FirstOrDefaultAsync(x=>x.Id==id);
            return View(studData);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var studDataEdit = await _studDb.Students.FindAsync(id);
            
            return View(studDataEdit);
        }

        [HttpPost]
        public async Task<IActionResult> EditResult(int id,Student stdUpdate)
        {
            _studDb.Students.Update(stdUpdate);
            await _studDb.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> DeleteFetch(int id)
        {
            var studDelete = _studDb.Students.FirstOrDefault(x=>x.Id == id);
           
            return View(studDelete);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var studDelete = await _studDb.Students.FindAsync(id);
            _studDb.Students.Remove(studDelete);
            _studDb.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }






















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}