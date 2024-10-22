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
                TempData["success"] = "create new record";
                return RedirectToAction("Index");
            }
            return View(newMphasis);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null|| id == 0)
            {
                return NotFound();
            }
            var obj = _context.mphases.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Mphasis obj)
        {
            if (ModelState.IsValid)
            {
                _context.mphases.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "update recorded";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null|| id == 0)
            {
                return NotFound();
            }
            var obj = _context.mphases.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Mphasis mphasis)
        {
            if (ModelState.IsValid)
            {
                _context.mphases.Remove(mphasis);
                _context.SaveChanges();
                TempData["success"] = "delete record successfully";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
 