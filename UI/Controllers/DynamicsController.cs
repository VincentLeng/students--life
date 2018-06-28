using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
using Model;
using UI.Models;
using System.Text.RegularExpressions;
using UI.Attributes;

namespace UI.Controllers
{
    public class DynamicsController : Controller
    {
        TaskEntities DbContext = new TaskEntities();
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        UsersBLL usersBLL = new UsersBLL();
        PostBLL postBLL = new PostBLL();
        // GET: Dynamics
        public ActionResult Index()
        {
            var vm = new DynamicsMultiViewModel();
            var dynamics = dynamicsBLL.GetDAL().GetALL();
            //var images = imagesBLL.GetDAL().GetKey(); //不能实现通过图片id进行查询？
            //var users = usersBLL.GetDAL().GetALL();
            IList<DynamicsViewModel> vmlist = new List<DynamicsViewModel>();
            foreach (var dynamic in dynamics)
            {
                var _user = usersBLL.GetDAL().GetById(dynamic.UserId);
                var _image = _user.Images.SingleOrDefault();
                vmlist.Add
                (new DynamicsViewModel
                {
                    dynamic = dynamic,
                    user = _user,
                    image = _image,
                }
                );
            }

            vm.DynamicsViewModels = vmlist;
            return View(vm);
        }
        //发帖post
        public ActionResult Post(Post post)
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]//udeitor附文本编辑器的使用！！！
        [Login]
        public ActionResult PostSend()
        {
            //if (ModelState.IsValid)
            //{
            //    post.UserId = (int)Session["UserId"];
            //    post.DynamicContent = null;
            //    if (Session["UserId"] != null)
            //    {
            //        post.PostId = (int)Session["UserId"];
            //        postBLL.Add(post);
            //    }
            //    else
            //    {
            //        postBLL.Add(post);
            //    }

            //    DbContext.Post.Add(post);
            //    DbContext.SaveChanges();
            //    //return RedirectToAction("Index");
            //    return Content("<script>;alert('发布成功！');window.history.go(-2);window.location.reload();</script>");
            //}
            //else
            //{
            //    return Content("<script>;alert('发布失败！');history.go(-1)</script>");
            //}
            var dynamics = new Dynamics();
            int UserId = Convert.ToInt32(Session["UserId"]);
            dynamics.DynamicContent = Request.Form["DynamicContent"];
            if (dynamics.DynamicContent == "")
            {
                return Content("<script>;alert('帖子内容不能为空');window.open('" + Url.Action("Index", "Home") + "', '_self' </script>");
            }
            else
            {
                dynamics.UserId = UserId;
                dynamics.DynamicTime = DateTime.Now;
                var success = dynamicsBLL.GetDAL().Add(dynamics);
                return RedirectToAction("Index");
            }
        }
    }
}

