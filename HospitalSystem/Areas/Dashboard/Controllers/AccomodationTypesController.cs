using HMS.Entities;
using HMS.Services;
using HospitalSystem.Areas.Dashboard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalSystem.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {


        AccomodationTypesService service = new AccomodationTypesService();
        // GET: Dashboard/AccomodationTypes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            AccomodationTypesListingModel model = new AccomodationTypesListingModel();

            model.AccomodationType = service.GetAccomodationTypes();

            return PartialView("_Listing",model);
        }


        [HttpGet]
        public ActionResult ActionChng()
        {
            AccomodationTypesActionChngModel model = new AccomodationTypesActionChngModel();

            return PartialView("_ActionChng",model);
        }

        //[HttpPost]
        //public ActionResult ActionChng(AccomodationTypesActionChngModel acModel)
        //{
        //    AccomodationTypes accomType = new AccomodationTypes();
        //    accomType.Name = acModel.Name;

            

        //    return PartialView("_ActionChng", model);
        ////}
    }
}