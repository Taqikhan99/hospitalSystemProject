using HMS.Data;
using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Services
{
    public class AccomodationTypesService
    {
        public List<AccomodationTypes> GetAccomodationTypes()
        {
            var context = new HMSContext();

            return context.AccomodationType.ToList();
        }

        public bool SaveAccomodationType(AccomodationTypes accomType)
        {
            var context = new HMSContext();
            context.AccomodationType.Add(accomType);
            return context.SaveChanges()>0;
        }
    }
}
