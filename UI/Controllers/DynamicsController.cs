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

namespace UI.Controllers
{
    public class DynamicsController : Controller
    {
        DynamicsBLL dynamicsBLL = new DynamicsBLL();
        ImagesBLL imagesBLL = new ImagesBLL();
        UsersBLL usersBLL = new UsersBLL();
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
                var _image = imagesBLL.GetDAL().GetById(_user.ImageId.Value);
                vmlist.Add(new DynamicsViewModel
                {
                    dynamic = dynamic,
                    user = _user,
                    image = _image,
                });
            }

            vm.DynamicsViewModels = vmlist;
            return View(vm);
        }
        //发帖post
        [HttpPost]
        [ValidateInput(false)]//udeitor附文本编辑器的使用！！！
        public ActionResult PostSend(Dynamics dynamic)
        {
            if (ModelState.IsValid)
            {
                dynamic.DynamicTime = System.DateTime.Now;
                dynamic.UserId = (int)Session["UserId"];
                dynamic.ComId = 0;
                dynamic.DynId = 0;
                dynamic.DynamicContent = null;
                if (Session["DynamicContent"] != null)
                {
                    dynamic.DynId = (int)Session["DynamicContent"];
                    dynamicsBLL.Update(dynamic);
                }
                else
                {
                    dynamicsBLL.Add(dynamic);
                }

                //db.Post.Add(post);
                //db.SaveChanges();
                //return RedirectToAction("Index");
                return Content("<script>;alert('发布成功！');window.history.go(-2);window.location.reload();</script>");
            }
            else
            {
                return Content("<script>;alert('发布失败！');history.go(-1)</script>");
            }
        }
    }
}
