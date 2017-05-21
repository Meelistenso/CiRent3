using CiRent.BL.Concrete;
using CiRent.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CiRent.WebUi.Controllers
{
    /// <summary>
    /// http://stackoverflow.com/questions/5095183/how-would-i-run-an-async-taskt-method-synchronously
    /// </summary>
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
        public  PartialViewResult _Categories(int id)
        {
            DataHandler c = new DataHandler();
            return PartialView(c.BindSideBarCategories(id).GetAwaiter());
        }
    }
}