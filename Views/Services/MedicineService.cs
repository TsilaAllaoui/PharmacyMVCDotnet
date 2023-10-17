using Microsoft.EntityFrameworkCore;
using PharmacyMVC.Data;
using PharmacyMVC.Models;

namespace PharmacyMVC.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly DataContext _context;
        public MedicineService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Medicine>> GetAllMedicines()
        {
            return await _context.Medicines.ToListAsync();
        }

        public async Task<Medicine> GetSingleMedicineById(long id)
        {
            var medicine = await _context.Medicines.FindAsync(id);
            if (medicine is null)
            {
                throw new Exception($"Item with ID:{id} not found!");
            }

            return medicine;
        }

        public async Task<bool> AddMedicine(Medicine medicine)
        {
            var medicineAdded = await _context.Medicines.AddAsync(medicine);
            return medicineAdded is not null;
        }

        public async Task<bool> UpdateMedicine(Medicine newMedicine)
        {
            var updatedMedicine = _context.Medicines.Update(newMedicine);
            return updatedMedicine is not null;
        }

        public async Task<bool> DeleteMedicine(long id)
        {
            var foundMedicine = await _context.Medicines.FindAsync( id);
            if (foundMedicine is null)
            {
                throw new Exception($"Item with ID:{id} not found!");
            }
            _context.Medicines.Remove(foundMedicine);
            return foundMedicine is not null;
        }
    }
}