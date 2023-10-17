using PharmacyMVC.Models;

namespace PharmacyMVC.Services
{
    public interface IMedicineService
    {
        public Task<List<Medicine>> GetAllMedicines();
        public Task<Medicine> GetSingleMedicineById(long id);
        public Task<bool> AddMedicine(Medicine mediicine);
        public Task<bool> UpdateMedicine(Medicine newMedicine);
        public Task<bool> DeleteMedicine(long id);
    }
}