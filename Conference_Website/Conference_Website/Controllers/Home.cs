using Conference_Website.Context;
using Conference_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Conference_Website.Controllers
{
    public class Home : Controller
    {
        private readonly DatabaseContext _context;
        public Home(DatabaseContext context)
        {
            _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            return View();
        }
    }
}
