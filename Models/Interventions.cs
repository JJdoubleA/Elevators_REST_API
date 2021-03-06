using System;
using System.Collections.Generic;

namespace Elevators_REST_API.Models
{
    public partial class Interventions
    {
        public long Id { get; set; }
        public long? AuthorId { get; set; }
        public long CustomerId { get; set; }
        public long BuildingId { get; set; }
        public long? BatteryId { get; set; }
        public long? ColumnId { get; set; }
        public long? ElevatorId { get; set; }
        public long? EmployeeId { get; set; }
        public string Result { get; set; }
        public string Report { get; set; }
        public string Status { get; set; }
        public DateTime? Start_date {get; set; }
        public DateTime? End_date {get; set; }

        public virtual Employees Author { get; set; }
        public virtual Batteries Battery { get; set; }
        public virtual Buildings Building { get; set; }
        public virtual Columns Column { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Elevators Elevator { get; set; }
        public virtual Employees Employee { get; set; }
    }
}
