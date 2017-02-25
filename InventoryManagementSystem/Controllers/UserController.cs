using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {

                return View();
            }
        }
    }
}