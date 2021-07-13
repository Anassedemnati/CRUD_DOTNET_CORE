using inandout.Data;
using inandout.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expense;
            return View(objList);
        }
        //get
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TypeDropDow = _db.ExpensesCategorys.Select(i => new SelectListItem
            {
                Text= i.CatName,
                Value = i.Id.ToString()

            });
            ViewBag.TypeDropDow = TypeDropDow;
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            if (ModelState.IsValid)
            {
                obj.categoryId = obj.categoryId;
                _db.Expense.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
           
            
        }
        //get for delete
       
        public IActionResult Delete(int? id)
        {
            
            if(id == null || id ==0)
            {
                return NotFound();
            }
            var obj = _db.Expense.Find(id);
           
            if(obj== null)
            {

                return NotFound();
            }

            return View(obj);
           


        }
        //post for delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? ExpenseId)
        {
            var obj = _db.Expense.Find(ExpenseId);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Expense.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");



        }
        //get for Update

        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expense.Find(id);

            if (obj == null)
            {

                return NotFound();
            }

            return View(obj);



        }
        //POST Upadete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expense.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);


        }
    }
}
