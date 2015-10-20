using KodmardenSaldo.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KodmardenSaldoSolution.Controllers
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