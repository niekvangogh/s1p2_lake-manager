using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat_application
{
    public class Lake
    {

        public Boat Boat { get; set; }

        public void CreateBoat(string name, int maxCapacity, BoatType boatType)
        {
            this.Boat = new Boat(name, maxCapacity, boatType);
        }

        public bool AddCrew(Crew crew)
        {
            return this.Boat.Add(crew);
        }

        public bool RemoveCrew(Crew crew)
        {   
            return this.Boat.Remove(crew);
        }

        public List<Crew> ReturnCrew()
        {
            return this.Boat.CrewMembers;
        }
    }
}
