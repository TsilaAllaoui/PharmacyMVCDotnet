using Microsoft.EntityFrameworkCore;
using PharmacyMVC.Data;
using PharmacyMVC.Models;

namespace PharmacyMVC.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly DbContext _context;
        public MedicineService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Medicine>> GetAllMedicines()
        {
            throw new NotImplementedException();
        }

        public Task<Medicine> GetSingleMedicineById(long id)
        {
            throw new NotImplementedException();
        }

        public bool AddMedicine(Medicine mediicine)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMedicine(Medicine newMedicine)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMedicine(long id)
        {
            throw new NotImplementedException();
        }
    }
}