using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVC.Controllers
{
    [RoutePrefix("MachineCustomization/ScreenViewsEdit"), Route("{action=index}")]
    public class ScreenViewsEditController : Controller
    {
        // GET: ScreenViewsEdit
        public ActionResult Index()
        {
            return View("~/Views/ScreenViewsEdit/ScreenViewsEdit.cshtml");
        }

        [HttpGet]
        public ActionResult ScreenViewsEdit()
        {
            string redirectUrl = "./ScreenViewsEdit/Index";
            return Json(new { redirectUrl = redirectUrl }, JsonRequestBehavior.AllowGet);
        }
    }
}