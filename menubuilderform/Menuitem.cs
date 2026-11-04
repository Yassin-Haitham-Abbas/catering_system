namespace menubuilderform
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal PricePerPerson { get; set; }
        public Category Category { get; set; }
        public override string ToString() => $"{Name} ({PricePerPerson:C})";
    }
}