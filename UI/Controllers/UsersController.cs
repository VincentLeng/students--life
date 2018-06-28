using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using DAL;
using Model;
using UI.Models;
using UI.Attributes;

namespace UI.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        UsersBLL usersBLL = new UsersBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        ReceiveBLL receiveBLL = new ReceiveBLL();
        ActivitiesBLL activitiesBLL = new ActivitiesBLL();
        public ActionResult Index()
        {
            return View();
        }

        //注册
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register([Bind(Include = "UsersName,Password,Email")] Users users)
        {
            if (ModelState.IsValid)
            {
                //users.UserName = null;
                //users.Password = null;
                //users.Email = null;
                //Users  users = usersBLL.GetDAL().Add(users);

                UsersBLL ii = new UsersBLL();
                var uu = ii.GetDAL().AddUser(users);

                return Content("<script>;alert('注册成功!');window.location.href='/Users/Login';</script>");
            }
            else
            {
                return Content("<script>;alert('注册失败！');history.go(-1)</script>");
            }
        }
        //登录
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "UserName,Password")]string UserName, string Password)
        {
            var users = usersBLL.GetDAL().Denglu(UserName, Password);
            if (users != null)
            {
                //保存到Session HttpContext.
                Session["UserId"] = users.UserId;
                //Session["UserName"] = UserName;
                //Session["Password"] = Password;
                Session["User"] = users;
                return Content("<script>alert('登录成功!');window.location.href='/'</script>");
            }
            else
            {
                return Content("<script>;alert('登录失败！');history.go(-1)</script>");
            }
        }
            
        //注销
        [HttpGet]
        public ActionResult Zhuxiao()
        {
            //保存到Session HttpContext.
            Session["UserId"] = null;
            return Redirect("/users/login");
        }
        
        [ValidateInput(false)]
        [Login]

        //个人中心页面
        public ActionResult UserCenter(int UserId)
        {
            TaskEntities DbContext = new TaskEntities();
            UsersViewModel uv = new UsersViewModel();
            int id = Convert.ToInt32(Session["UserId"]);
            var users = DbContext.Users.Where(c => c.UserId == id);
            uv.Users = users;
            ViewBag.UserId = UserId;
            //发动态
            uv.Dynamics = dynamicsBLL.GetDAL().GetList(3, 1);
            //接取的兼职
            var a = receiveBLL.GetDAL().getrecivebyuid(UserId);
            uv.Receive = a;
            return View(uv);
           
        }


    }
}
