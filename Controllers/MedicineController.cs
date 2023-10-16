using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyMVC.Data;
using PharmacyMVC.Models;

namespace PharmacyMVC.Controllers
{
    public class MedicineController : Controller
    {
        private readonly DataContext _context;

        public MedicineController(DataContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var medicines =  _context.Medicines.ToList();
            Console.WriteLine(medicines.Count);
            return View(medicines);
        }
    }
}
