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
        UsersBLL usersBLL = new UsersBLL();
        ReceiveBLL receiveBLL = new ReceiveBLL();
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
            ViewBag.CurrentPageIndex = page;
            return View(acvm);
        }
        public ActionResult getActivities(int actid)

        {
            TaskEntities DbContext = new TaskEntities();
            //activities.Add(activities);
            Receive receive = new Receive();
            int id = Convert.ToInt32(Session["UserId"]);
            receive.UserId = id;
            receive.ReceiveTime = DateTime.Now;
            receive.ActId = actid;
            receiveBLL.Add(receive);
            return Redirect(Url.Action("UserCenter","Users",new { userid=Session["UserId"]}));
                //Content("<script>alert('预约成功！');window.open('" + Url.Content("~/Student/Index") + "', '_blank')</script>");

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

    
