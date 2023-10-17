using PharmacyMVC.Models;

namespace PharmacyMVC.Services
{
    public interface IMedicineService
    {
        public Task<List<Medicine>> GetAllMedicines();
        public Task<Medicine> GetSingleMedicineById(long id);
        public bool AddMedicine(Medicine mediicine);
        public bool UpdateMedicine(Medicine newMedicine);
        public bool DeleteMedicine(long id);
    }
}