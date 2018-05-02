using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace UI.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Images> Images { get; set; }
        public IEnumerable<Dynamics> Dynamics{ get; set; }
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<Activities> Activities{ get; set; }

    }
}