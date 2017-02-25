using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using InventoryManagementSystem.Context;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        InventoryManagementSystem_DBContext Context = new InventoryManagementSystem_DBContext();
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                User user = (User) Session["user"];
                ViewBag.name = user.User_name;
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            if (Session["User"] != null)
            {
                User user = (User)Session["User"];
                ViewBag.some = user.User_name;
                ViewData["Sub_category"] = new SelectList(Context.SubCategories, "Sub_Category_Id", "Sub_Category_name");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        [HttpGet]
        public ActionResult CreateCategory()
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

        [HttpGet]
        public ActionResult CreateSubCategory()
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

        [HttpGet]
        public ActionResult CreateUser()
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


        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("Login", "Home");
        }
    }
}