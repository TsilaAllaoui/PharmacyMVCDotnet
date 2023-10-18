namespace PharmacyMVC.Models
{
    public class Medicine
    {
        public long Id { get; set; }
        public required string Name { get; set; }

        public int Price { get; set; }
        public long Quantity { get; set; }

        public string Image { get; set; } = "https://placehold.co/600x400";

        public MedicineType Type { get; set; }
    }
}
