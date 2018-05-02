using System.Web.Mvc;
using Model;
using BLL;
using System.Linq;

namespace UI.Controllers
{
    public class ActivitiesController : Controller
    {
        ActivitiesBLL activitiesBll = new ActivitiesBLL();
        // GET: Activities
        public ActionResult Index()
        {
           ViewData.Model= activitiesBll.GetList(10, 1);//主页一页放十条，分页
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Add(Activities activities)
        {
            activitiesBll.Add(activities);
            return Redirect(Url.Action("Index"));
        }

    }
}