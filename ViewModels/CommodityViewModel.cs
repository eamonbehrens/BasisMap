using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BasisMap.Models;
using BasisMap.DBContext;
using BasisMap.Interfaces;
using System.Linq;

namespace BasisMap.ViewModels
{
    public class CommodityViewModel
    {


        //[Key]
        //public int ID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
        public IEnumerable<Commodity> CommoditiesList { get; set; }
        // public Commodity Commodities { get; set; }
       public IEnumerable<SelectListItem> CommodityCodes { get; set; }
        // var list = from c in Commodity select
        //public List<SelectListItem> Commodities { get; } = new List<SelectListItem>
        //{


        //    new SelectListItem { Value = "MX", Text = "Mexico" },
        //    new SelectListItem { Value = "CA", Text = "Canada" },
        //    new SelectListItem { Value = "US", Text = "USA"    },
        //    new SelectListItem { Value = "FR", Text = "France" },
        //    new SelectListItem { Value = "ES", Text = "Spain"  },
        //    new SelectListItem { Value = "DE", Text = "Germany"}
        // };
    


        //CommodityBoardOfTrade = new HashSet<CommodityBoardOfTrade>();
        //LocationCommodity = new HashSet<LocationCommodity>();
        //MarketSituation = new HashSet<MarketSituation>();
        //Ticket = new HashSet<Ticket>();
        //var CornGroup = new SelectListGroup { Name = "Corn" };
        //var WheatGroup = new SelectListGroup { Name = "Wheat" };

        //Commodities = new List<SelectListItem>
        //    {
        //        new SelectListItem
        //        {
        //            Value = com.Code,
        //            Text = com.Description,
        //            //Group = CornGroup
        //        },
        //new SelectListItem
        //{
        //    Value = "01",
        //    Text = "Corn2",
        //    //Group = CornGroup
        //},
        //new SelectListItem
        //{
        //    Value = "01",
        //    Text = "04",
        //    Group = CornGroup
        //},
        //new SelectListItem
        //{
        //    Value = "02",
        //    Text = "HRW",
        //    Group = WheatGroup
        //},
        //new SelectListItem
        //{
        //    Value = "02",
        //    Text = "SRW",
        //    Group = WheatGroup
        //},
        //new SelectListItem
        //{
        //    Value = "02",
        //    Text = "MRW",
        //    Group = WheatGroup
        //}
           



    
  



    }
}
