
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasisMap.Models;

namespace Lansing.BasisMap.Views.Shared
{
    public class LayoutViewModel
    {
      public  IEnumerable<SelectListItem> CommoditiesFilter { get; set; }
        public Commodity Commodity { get; set; }
    }
}
