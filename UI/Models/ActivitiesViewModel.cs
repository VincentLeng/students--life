using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;


namespace UI.Models
{
    public class ActivitiesViewModel
    {
        public IEnumerable<Activities> Activities { get; set; } //前面的activities是model中的     
        public IEnumerable<Categories> Categories { get; set; }
        public IEnumerable<Images> Images { get; set; }//在兼职页面布局相应的图标以及图片
        public int ActivitiesCount { get; set; }
        public IEnumerable<Users> Users { get; set; }
    }
}