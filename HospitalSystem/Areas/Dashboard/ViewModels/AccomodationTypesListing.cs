using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem.Areas.Dashboard.ViewModels
{
    public class AccomodationTypesListingModel
    {
        public List<AccomodationTypes> AccomodationType { get; set; }
    }

    public class AccomodationTypesActionChngModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}