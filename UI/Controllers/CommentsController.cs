﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace UI.Controllers
{
    public class CommentsController : Controller
    {
        
        // GET: Comments
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        } 

    }
}