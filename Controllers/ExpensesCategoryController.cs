using inandout.Data;
using inandout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Controllers
{
    public class ExpensesCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpensesCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ExpensesCategory> objList = _db.ExpensesCategorys;
            return View(objList);
        }
        //GET-Create
        public IActionResult Create()
        {
            return View();
        }
        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpensesCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesCategorys.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        //get for delete

        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpensesCategorys.Find(id);

            if (obj == null)
            {

                return NotFound();
            }

            return View(obj);



        }
        //post for delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var obj = _db.ExpensesCategorys.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpensesCategorys.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        //get for Update

        public IActionResult Update(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpensesCategorys.Find(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //post for update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpensesCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesCategorys.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
