using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Accomodations
    {
        public int Id { get; set; }

        public int AccomodationPackageId { get; set; }
        public AccomodationPackages AcmPackage { get; set; }

        public string Name { get; set; }
    }
}
