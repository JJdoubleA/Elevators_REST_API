using System;
using System.Collections.Generic;

namespace Elevators_REST_API.Models
{
    public partial class BlazerDashboards
    {
        public long Id { get; set; }
        public long? CreatorId { get; set; }
        public string Name { get; set; }
    }
}
