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
    public class DynamicsController : Controller
    {
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        // GET: Dynamics
        public ActionResult Index()
        {
            var dynamics = dynamicsBLL.GetDAL().GetALL();
            //var images = imagesBLL.GetDAL().GetALL();
            return View();
        }
    }
}