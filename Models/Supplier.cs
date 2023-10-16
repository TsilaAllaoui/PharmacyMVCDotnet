namespace PharmacyMVC.Models
{
    public class Supplier
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public List<Medicine>? Medicines { get; set; }

    }
}
