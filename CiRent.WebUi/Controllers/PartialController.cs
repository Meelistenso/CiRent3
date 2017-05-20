using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiRent.WebUi.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public PartialViewResult _CartModal()
        {
            return PartialView();
        }
        public PartialViewResult _ProfileModal()
        {
            return PartialView();
        }
        public PartialViewResult _Categories()
        {
            return PartialView();
        }
    }
}