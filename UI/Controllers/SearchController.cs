using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace UI.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        CategoriesBLL categoriesBLL = new CategoriesBLL();
        ActivitiesBLL activitiesBLL = new ActivitiesBLL();
        Models.SearchViewModel searchvm = new Models.SearchViewModel();

        public ActionResult Index()
        {           
            //string search = Session["Search"].ToString();      
            var categories = categoriesBLL.GetDAL().GetList(5, 1);
            var activities = activitiesBLL.GetDAL().GetList(5, 1);
            Models.SearchViewModel searchvm = new Models.SearchViewModel();        
            searchvm.Categories = categories; 
            searchvm.Activities = activities;
            return View(searchvm);
        }
        //搜索页面
        [HttpPost]
        public ActionResult Index(string search)
        {
            Session["Search"] = search;
            searchvm.Categories = categoriesBLL.GetList(5,1);
            searchvm.Activities = activitiesBLL.GetList(5,1);
            return View(searchvm);
        }
    }
}