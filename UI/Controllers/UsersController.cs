using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
using UI.Models;

namespace UI.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        UsersBLL usersBLL = new UsersBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        ReceiveBLL receiveBLL = new ReceiveBLL();
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
                users.UserName = null;
                users.Password = null;
                users.Email= null;
                return Content("<script>;alert('注册成功!');window.history.go(-2); window.location.reload(); </script>");
            }
            else
            {
                return Content("<script>;alert('注册失败！');history.go(-1)</script>");
            }
        }
        [HttpPost]
        public string Login([Bind(Include = "UserName,Password")]string UserName, string Password)
        { 
                var users = usersBLL.GetDAL().Denglu(UserName, Password);
                if (users != null)
                {
                //保存到Session HttpContext.
                    Session["UserId"] = users.UserId;
                    Session["UserName"] = UserName;
                    Session["Password"] = Password;
                    string data = "登录成功";
                    return data;
                }
                else
                {
                    string data = "登录失败";
                    return data;
                }
            }

        //注销
        [HttpPost]
        public string Zhuxiao()
        {
            //保存到Session HttpContext.
            Session["UserId"] = null;
            string A = "a";
            return A;
        }

        //个人中心页面
        public ActionResult UserCenter(int UserId)
        {
            TaskEntities DbContext = new TaskEntities();
            UsersViewModel uv = new UsersViewModel();
            int id = Convert.ToInt32(Session["UserId"]);
            //uv.Users = 
            var users = DbContext.Users.Where(c => c.UserId == id);
            uv.Users = users;
            ViewBag.UserId = UserId;
            //发动态
            uv.Dynamics = dynamicsBLL.GetDAL().GetList(3, 1);
            //接取的兼职
            uv.Receive = receiveBLL.GetDAL().GetList(3, 1);
            return View(uv);
        }


    }
}
