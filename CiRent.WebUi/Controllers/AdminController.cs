using CiRent.BL.Concrete;
using CiRent.DAL.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace CiRent.WebUi.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        [Authorize]
        public async Task<ActionResult> Order()
        {
            DataHandler res = new DataHandler();
            var result = await res.BindOrder(User.Identity.GetUserId());
            return View(result);
        }
    }
}