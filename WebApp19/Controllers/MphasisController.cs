using Microsoft.AspNetCore.Mvc;
using WebApp19.Data;
using WebApp19.Models;

namespace WebApp19.Controllers
{
    public class MphasisController : Controller
    {
        private ApplicationDbContext _context;
        public MphasisController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Mphasis>mphases =_context.mphases;
            return View(mphases);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mphasis newMphasis)
        {
            if (ModelState.IsValid)
            {
                _context.mphases.Add(newMphasis);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newMphasis);
        }
    }
}
 