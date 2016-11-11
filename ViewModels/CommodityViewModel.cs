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

        public string Code { get; set; }

        public string Description { get; set; }
        public SelectList CommodityCodes { get; set; }

       // public IEnumerable<SelectListItem> CommodityCodes { get; set; }

    


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
