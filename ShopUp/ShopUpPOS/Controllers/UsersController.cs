 using Microsoft.AspNetCore.Mvc;
using ShopUpPOS.Data;
using ShopUpPOS.Models;

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
        public IActionResult Edit(int? name)
        {
            if(name== null || name == 0)
            {
                return NotFound();
            }
            Users? UserformDb = _db.Users.Find(name);

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
                _db.Users.Add(objUser);
                _db.SaveChanges();
                return RedirectToAction("Index", "Users");
            }
            else
                return View();

        }


    }
}
