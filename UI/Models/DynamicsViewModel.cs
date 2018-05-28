using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace UI.Models
{
    public class DynamicsViewModel
    {
        public IEnumerable<Dynamics> Dynamics { get; set; }
        public IEnumerable<Images> Images { get; set; }    
    }
}