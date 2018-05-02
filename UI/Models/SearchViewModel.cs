using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;

namespace UI.Models
{
    public class SearchViewModel
    {
        public IEnumerable<Activities> Activities { get; set; }   
        public IEnumerable<Categories> Categories { get; set; }
    }
}