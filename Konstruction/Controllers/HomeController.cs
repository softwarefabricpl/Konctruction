using Konstruction.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Konstruction.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static bool CheckRights()
        {
            var ui = CommonHelper.GetUserInfo();
            return ui != null;
        }

        public ActionResult Index()
        {
            if (CheckRights() == false)
                return RedirectToAction("LogOff", "Security");

            return View();
        }
    }
}

public enum HeaderViewRenderMode { Full, Title }