using System.Collections.Generic;
using BasisMap.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasisMap.ViewModels;

namespace BasisMap.Interfaces
{
    public interface ICommodityRepository
    {
       

        IEnumerable<Commodity> ListAll();



        // IEnumerable<string> GetCommodityDropDown();
        SelectList GetCommodityDropDown();
        //IEnumerable<CommodityViewModel> GetCommodities();
    }
}