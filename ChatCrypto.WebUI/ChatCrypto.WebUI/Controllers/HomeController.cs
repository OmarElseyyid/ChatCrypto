﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChatCrypto.WebUI.Models;
namespace ChatCrypto.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private chat_dbEntities db = new chat_dbEntities();
        public ActionResult Index()
        {
            return View(db.Accounts.ToList());
        }

        public ActionResult PartialUsersList()
        {
            return View(db.Accounts.ToList());
        }
        public ActionResult PartialUsersDesc(string Username, string Password)
        {
            //return View(db.Accounts.Where(x => x.Username == Username && x.Password == Password).ToList());
            return View();
        }

    }
}