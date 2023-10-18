using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyMVC.Data;
using PharmacyMVC.Models;
using PharmacyMVC.Services;

namespace PharmacyMVC.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineService _medicineService;

        public MedicineController(IMedicineService medicineService) 
        {
            _medicineService = medicineService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _medicineService.GetAllMedicines());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Medicine medicine)
        {
            if (!ModelState.IsValid)
            {
                return View(medicine);
            }
            await _medicineService.AddMedicine(medicine);
            return RedirectToAction("Index");
        }
    }
}
