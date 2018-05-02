using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
using Model;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        ImagesBLL imagesBLL = new ImagesBLL();
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        UsersBLL usersBLL = new UsersBLL();
        ActivitiesBLL activitiesBLL = new ActivitiesBLL();
        public ActionResult Index()
        {
            var images = imagesBLL.GetDAL().GetALL(); 
            var dynamics = dynamicsBLL.GetDAL().GetList(3,1);
            var users = usersBLL.GetDAL().GetList(3, 1);
            var activities = activitiesBLL.GetDAL().GetList(3, 1);
            Models.HomeIndexViewModel homevm = new Models.HomeIndexViewModel();
            homevm.Images = images;
            homevm.Dynamics = dynamics;
            homevm.Users = users;
            homevm.Activities = activities;
            return View(homevm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}