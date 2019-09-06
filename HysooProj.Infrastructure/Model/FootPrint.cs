using System;
using System.Collections.Generic;
using System.Text;

namespace HyesooProj.Infrastructure.Model
{
    public class FootPrint
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public DailyFootPrint Daily { get; set; }

        public List<CoffeeTime> CoffeeTimes { get; set; }
    }
}
