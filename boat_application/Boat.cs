using System.Collections.Generic;

namespace boat_application
{
    public class Boat
    {

        public int MaxCapacity { get; set; }

        public string Name { get; set; }

        public List<Crew> CrewMembers { get; set; }

        public BoatType BoatType { get; set; }

        public Boat(string name, int maxCapacity, BoatType boatType)
        {
            this.Name = name;
            this.MaxCapacity = maxCapacity;
            this.BoatType = boatType;

            this.CrewMembers = new List<Crew>();
        }

        public bool Add(Crew crew)
        {
            if (this.CrewMembers.Capacity < this.MaxCapacity)
            {
                this.CrewMembers.Add(crew);
                return true;
            }
            return false;
        }

        public bool Remove(Crew crew)
        {
            return this.CrewMembers.Remove(crew);
        }
    }

    public enum BoatType
    {
        SNELLE_BOOT, HARRY_DE_SPEEDBOOT
    }
}