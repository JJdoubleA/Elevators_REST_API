using System;
using System.Collections.Generic;

namespace Elevators_REST_API.Models
{
    public partial class Columns
    {
        public Columns()
        {
            Elevators = new HashSet<Elevators>();
            Interventions = new HashSet<Interventions>();
        }

        public long Id { get; set; }
        public string BuildingType { get; set; }
        public int? NumberOfFloorsServed { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public long? BatteryId { get; set; }

        public virtual Batteries Battery { get; set; }
        public virtual ICollection<Elevators> Elevators { get; set; }
        public virtual ICollection<Interventions> Interventions { get; set; }
    }
}
