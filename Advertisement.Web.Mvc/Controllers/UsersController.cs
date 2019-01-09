using Advertisement.Application.Contract;
using Advertisement.Application.ViewModel;
using System.Web.Mvc;

namespace Advertisement.Web.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private IUserContract _userContract;

        public UsersController(IUserContract userContract)
        {
            _userContract = userContract;
        }

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginViewModel model)
        {
            var loginMessage = _userContract.Login(model);

            if (loginMessage.Failed)
            {
                TempData["message"] = "مشخصات ورود به سیستم اشتباه می باشد";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index", "Dashboard", new { area = "Manager" });
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Create(RegisterViewModel model)
        {
            var resgisterMessage = _userContract.Register(model);

            if (resgisterMessage.Failed)
            {
                TempData["message"] = "مشخصات ایجاد حساب کاربری اشتباه می باشد";
                return View("Register" , model);
            }
            return RedirectToAction("Index", "Dashboard", new { area = "Manager" });
        }

    }
}