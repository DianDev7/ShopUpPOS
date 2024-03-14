 using Microsoft.AspNetCore.Mvc;
using ShopUpPOS.Data;
using ShopUpPOS.Models;
using static Azure.Core.HttpHeader;

namespace ShopUpPOS.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _db;
        public UsersController(ApplicationDBContext db)
        {
            _db = db;
        }
        
            
        
        public IActionResult Index()
        {
            List<Users> objUsers = _db.Users.ToList();
            return View(objUsers);
        }

        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(Users objUser)
        {

            if (ModelState.IsValid)
            {
                _db.Users.Add(objUser);
                _db.SaveChanges();
                return RedirectToAction("Index", "Users");
            }
            else
                return View();

        }
        public IActionResult Edit(string? name)
        {
            if(name== null)
            {
                return NotFound();
            }
            Users? UserformDb = _db.Users.FirstOrDefault(x => x.Name == name);

            if (UserformDb == null)
            {
                return NotFound();
            }
            return View(UserformDb);
        }
        [HttpPost]
        public IActionResult Edit(Users objUser)
        {

            if (ModelState.IsValid)
            {
                _db.Users.Update(objUser);
                _db.SaveChanges();
                return RedirectToAction("Index", "Users");
            }
            else
                return View();

        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            Users? UserformDb = _db.Users.Find(Id);

            if (UserformDb == null)
            {
                return NotFound();
            }
            return View(UserformDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Users? objuser = _db.Users.Find(Id);
               if (objuser == null)
            {
                return NotFound();
            }
               _db.Users.Remove(objuser);
               _db.SaveChanges();
               return RedirectToAction("Index");
            
        }


    } 
}
