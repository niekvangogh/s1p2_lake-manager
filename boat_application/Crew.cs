namespace boat_application
{
    public class Crew
    {
        public string Name { get; }

        public int Weight { get; set; }

        public Crew(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}