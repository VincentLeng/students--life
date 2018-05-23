using System;
using System.Web.Mvc;
using BLL;
using Model;
using DAL;




namespace UI.Controllers
{
    public class ActivitiesController : Controller
    {
        ActivitiesBLL activitiesBLL = new ActivitiesBLL();
        CategoriesBLL categoriesBLL = new CategoriesBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        // GET: Activities
        public ActionResult Index()
        {
            var categories = categoriesBLL.GetDAL().GetALL();
            var activities = activitiesBLL.GetDAL().GetList(10, 1);
            //一页展示10条数据，使用分页
            Models.ActivitiesViewModel acvm = new Models.ActivitiesViewModel();
            acvm.Activities = activities;
            acvm.Categories = categories;
            return View(acvm);
        }
        //分页实现，get获取数据
        [HttpGet]
        public ActionResult FenYe(int page)
        {
            //var activities = activitiesBLL.GetDAL().GetALL();
            //int pageNumber = page;
            var sort1 = db.ShiType.ToList();
            var foods = shi.GetShi();
            if (genreInfoFrom != null)
            {
                page = 1;
            }
            else
            {
                genreInfoFrom = currentFilter;
            }
            ViewBag.CurrentFilter = genreInfoFrom;
            if (!String.IsNullOrEmpty(genreInfoFrom))
            {
                foods = foods.Where(x => x.ShiType.ShiTypeName == genreInfoFrom);
            }
            int pageSize = 9;
            int pageNumber = (page ?? 1);
            var menu = new TypeViewModels()
            {
                Type = sort1,
                TypeShi = foods.ToPagedList(pageNumber, pageSize),
            };
            return PartialView("ShiIndex", menu);

            return Content($"<h1>{page}</h2>");
        }
    }
        }

    
