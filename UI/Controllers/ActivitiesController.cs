using System;
using System.Web.Mvc;
using BLL;
using Model;
using DAL;
using System.Linq;

namespace UI.Controllers
{
    public class ActivitiesController : Controller
    {
        ActivitiesBLL activitiesBLL = new ActivitiesBLL();
        CategoriesBLL categoriesBLL = new CategoriesBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        static int count = 0;

        // GET: Activities
        public ActionResult Index(int page = 1)
        {
            count = count != 0 ? count : activitiesBLL.GetDAL().GetALL().Count();
            var categories = categoriesBLL.GetDAL().GetALL();
            var activitiesCount = count;
            var activities = activitiesBLL.GetDAL().GetList(10, page);
            //一页展示10条数据，使用分页
            Models.ActivitiesViewModel acvm = new Models.ActivitiesViewModel();
            acvm.Activities = activities.ToList();
            acvm.Categories = categories.ToList();
            acvm.ActivitiesCount = activitiesCount;
            return View(acvm);
        }
        //分页实现，get获取数据
        //[HttpGet]
        //public ActionResult FenYe(int page)
        //{
        //    //var activities = activitiesBLL.GetDAL().GetALL();
        //    //int pageNumber = page;   
        //    var activities = activitiesBLL.GetDAL().GetALL();
        //    if (Content != null)
        //    {
        //        page = 1;
        //    }
        //    else
        //    {
                
        //    }
        //    return Content($"<h1>{page}</h2>");

        //}
    }
        }

    
