namespace PharmacyMVC.Models
{
    public class Medicine
    {
        public long Id { get; set; }
        public required string Name { get; set; }

        public int Price { get; set; }
        public long Quantity { get; set; }

        public MedicineType Type { get; set; }
    }
}
