using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Advertisement.Application.Contract;
using Advertisement.Application.Entities;

namespace Advertisement.Web.Mvc.Areas.Manager.Controllers
{
    public class CampainController : Controller
    {
        private readonly ICampainContract _campainContract;

        public CampainController(ICampainContract campainContract)
        {
            _campainContract = campainContract;
        }


        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var campains = _campainContract.GetAll();
            return View("List", campains);
        }

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// ViewModel can be used here if it's necessory
        /// </summary>
        /// <param name="campain"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Create(Campain campain)
        {
            //todo
            campain = new Campain
            {
                EndDate = DateTime.Now,
                StartDate = DateTime.Now,
                Name = "sdf"
            };

            _campainContract.Add(campain);
            _campainContract.Commit();
            return Json("");
        }
    }
}