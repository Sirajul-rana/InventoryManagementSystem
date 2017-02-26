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
                User user = (User)Session["user"];
                ViewBag.name = user.User_name;
                return View();
            }
        }
        public JsonResult SaveCategory(string txt_category)
        {
            if (txt_category != null)
            {
                Category category = new Category();
                category.Category_name = txt_category;
                Context.Categories.Add(category);
                Context.SaveChanges();
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            return Json("InvalidData", JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public ActionResult CreateCategory(Category category)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Categories.Add(category);
        //        Context.SaveChanges();
        //        return RedirectToAction("Index", "Admin");
        //    }
        //    else
        //    {
        //        return View(category);
        //    }
        //}

        [HttpGet]
        public ActionResult CreateSubCategory()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                User user = (User)Session["user"];
                ViewBag.name = user.User_name;
                ViewData["category"] = new SelectList(Context.Categories, "Category_Id", "Category_name");
                return View();
            }
        }

        public JsonResult SaveSubCategory(string txt_subcategory, string txt_categoryid)
        {
            if (txt_subcategory != null && txt_categoryid != null)
            {
                Sub_Category subCategory = new Sub_Category();
                subCategory.Sub_Category_name = txt_subcategory;
                subCategory.Category_Id = Convert.ToInt32(txt_categoryid);
                Context.SubCategories.Add(subCategory);
                Context.SaveChanges();
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            return Json("InvalidData", JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public ActionResult CreateSubCategory(Sub_Category subCategory)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string category_id = Request.Form["category"].ToString();
        //        subCategory.Category_Id = Convert.ToInt32(category_id);
        //        Context.SubCategories.Add(subCategory);
        //        Context.SaveChanges();
        //        return RedirectToAction("Index", "Admin");
        //    }
        //    else
        //    {
        //        return View(subCategory);
        //    }
        //}

        [HttpGet]
        public ActionResult CreateUser()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                User user = (User)Session["user"];
                ViewBag.name = user.User_name;
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