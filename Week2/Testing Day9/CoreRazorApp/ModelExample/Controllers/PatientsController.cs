using Microsoft.AspNetCore.Mvc;
using ModelExample.Data;
using ModelExample.Models;

namespace ModelExample.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;
       //constructor
        public PatientsController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()

        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Name,string Allergies)

        {
            Patients p = new Patients();
            p.Name=Name;
            p.Allergies=Allergies;
            _context.patients.Add(p);
            _context.SaveChanges();
            return RedirectToAction("index");
    }
}
    }
