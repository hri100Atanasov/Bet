namespace ConsoleApp1.Models
{
    public class Selection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Odds { get; set; }

        public override string ToString()
        {
            string result = $"Selection Id {Id}, Team {Name}, Odds {Odds}";

            return result;
        }
    }
}