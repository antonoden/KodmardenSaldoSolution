using KodmardenSaldo.Web.ViewModels;
using System.Web.Mvc;

namespace KodmardenSaldo.Web.Ui.Controllers
{
    public class AccountController : Controller
    {
        [Route("")]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                // loginmethod
            }
            return View(model);
        }
    }
}