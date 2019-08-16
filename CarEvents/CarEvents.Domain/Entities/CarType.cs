using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents.Domain.Entities
{
    public class CarType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
