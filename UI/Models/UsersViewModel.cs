using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace UI.Models
{
    public class UsersViewModel
    {
        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<Images> Images { get; set; }
        public IEnumerable<Receive> Receive { get; set; }
        public IEnumerable<Dynamics> Dynamics { get; set; }


    }
}