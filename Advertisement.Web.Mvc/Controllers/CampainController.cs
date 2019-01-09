using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Advertisement.Application.Contract;
using Advertisement.Application.Entities;

namespace Advertisement.Web.Mvc.Controllers
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
            return View();
        }
    }
}