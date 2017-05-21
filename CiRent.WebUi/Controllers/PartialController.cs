using CiRent.BL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<PartialViewResult> _Categories(int id)
        {
            DataHandler c = new DataHandler();
            var res= await c.BindSideBarCategories(id);
            return PartialView(res);
        }
    }
}