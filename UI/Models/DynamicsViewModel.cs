using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace UI.Models
{
    public class DynamicsViewModel
    {
        public Dynamics dynamic { get; set; }
        public Images image { get; set; }
        public Users user { get; set; }
    }

    public class DynamicsMultiViewModel
    {
        public IEnumerable<DynamicsViewModel> DynamicsViewModels { get; set; }
        public Dynamics NewDynamic { get; set; }
    }
}