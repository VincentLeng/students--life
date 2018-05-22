using System.Web.Mvc;
using Model;
using BLL;
using System.Linq;
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
             //主页一页放十条，分页
            Models.ActivitiesViewModel acvm = new Models.ActivitiesViewModel();
            acvm.Activities = activities;
            acvm.Categories = categories;
            return View(acvm);
        }    
    }
}