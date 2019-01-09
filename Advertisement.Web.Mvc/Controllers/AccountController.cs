using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Advertisement.Application.Contract;
using Advertisement.Application.ViewModel;

namespace Advertisement.Web.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserContract _userContract;

        public AccountController(IUserContract userContract)
        {
            _userContract = userContract;
        }


        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var message = _userContract.Login(model);

                if (message.Failed)
                {
                    // ye fent!
                    // alert => message.Body
                }
                else
                {
                    // khosh umadi
                }
            }


            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var message = _userContract.Register(model);

                if (message.Failed)
                {
                    //
                }
                else
                {
                    
                }
            }

            return View();
        }
    }
}