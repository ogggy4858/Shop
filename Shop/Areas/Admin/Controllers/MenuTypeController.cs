﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Framework;
using Data.MVC.DAO;

namespace Shop.Areas.Admin.Controllers
{
    public class MenuTypeController : Controller
    {
        MenuTypeDAO dao = new MenuTypeDAO();

        public ActionResult Index()
        {
         //   return View(dao.List());
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(dao.ViewDetails(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MenuType collection)
        {
            try
            {
                // TODO: Add insert logic here
                var res = dao.Insert(collection);
                if (res == true)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(dao.ViewDetails(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, MenuType collection)
        {
            try
            {
                // TODO: Add update logic here
                var res = dao.Update2(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(dao.ViewDetails(id));
        }

        [HttpPost]
        public ActionResult Delete(int id, MenuType collection)
        {
            try
            {
                // TODO: Add delete logic here
                var res = dao.Delete2(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
