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

        public async Task<IActionResult> Details(long id)
        {
            var medicine = await _medicineService.GetSingleMedicineById(id);
            return View(medicine);
        }

        public async Task<IActionResult> Edit(long id)
        {
            var medicine = await _medicineService.GetSingleMedicineById(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Medicine medicine)
        {
            if (!ModelState.IsValid)
            {
                return View(medicine);
            }
            await _medicineService.UpdateMedicine(medicine);
            return RedirectToAction("Details", "Medicine", new { id = medicine.Id });
        }
    }
}
