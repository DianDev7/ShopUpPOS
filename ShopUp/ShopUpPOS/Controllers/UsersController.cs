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
    }
}
