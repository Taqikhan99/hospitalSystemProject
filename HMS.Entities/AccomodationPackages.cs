using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccomodationPackages
    {
        public int Id { get; set; }

        public int AccomodationTypeId { get; set; }
        public AccomodationTypes AccomodationType { get; set; }
        public string Name { get; set; }
        public int NoOfRooms { get; set; }

        public decimal Fees { get; set; }
    }
}
