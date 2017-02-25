using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagementSystem.Context;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        InventoryManagementSystem_DBContext Context = new InventoryManagementSystem_DBContext();
        // GET: Home
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return View(Context.Users.ToList());
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public JsonResult CheckLogin(string txt_username, string txt_password)
        {
            var loginresult = Context.Users.FirstOrDefault(u => u.User_username == txt_username && u.User_password == txt_password);
            if (loginresult != null)
            {
                Session["user"] = loginresult;
                return Json(loginresult.User_type, JsonRequestBehavior.AllowGet);
            }
            return Json("InvalidData", JsonRequestBehavior.AllowGet);
        }
    }
}