using System.Collections.Generic;
using System.Linq;
using BasisMap.Interfaces;
using BasisMap.DBContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using BasisMap.ViewModels;

namespace BasisMap.Models.Repositories
{
    public class CommodityRepository : ICommodityRepository
    {
        


        private readonly ltgwarehouseContext _dbContext;

        public CommodityRepository(ltgwarehouseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Commodity> ListAll()
        {
            return _dbContext.Commodity.AsEnumerable();
        }
  

        public void Add(Commodity commodity)
        {
            _dbContext.Commodity.Add(commodity);
            _dbContext.SaveChanges();
        }
        //public IEnumerable<CommodityViewModel> GetCommodities()
        //{
        //    return _dbContext.CommodityViewModel.ToList();
        //}


        //public List<SelectListItem> GetList()
        //{

        //    return _dbContext.CommoditiesDrop.ToList();
        //}
        public SelectList GetCommodityDropDown()
        {
            return new SelectList(_dbContext.Commodity, "Oid", "Description");
        }
        // Just return a list of states - in a real-world application this would call
        // into data access layer to retrieve states from a database.
        //public IEnumerable<string> GetCommodityDropDown()
        //{
        //    Commodity model = new Commodity();
        //    var commodities = from c in model.Oid.ToString()
        //                      select c;
        //    //  var commodities = this.ListAll().ToString();

        //    return new List<string>
        //    {
          
        //        commodities.ToString()
           
               
                
        //    };
        //}
        // This is one of the most important parts in the whole example.
        // This function takes a list of strings and returns a list of SelectListItem objects.
        // These objects are going to be used later in the SignUp.html template to render the
        // DropDownList.
        //public IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        //{
        //    // Create an empty list to hold result of the operation
        //    var selectList = new List<SelectListItem>();

        //    // For each string in the 'elements' variable, create a new SelectListItem object
        //    // that has both its Value and Text properties set to a particular value.
        //    // This will result in MVC rendering each item as:
        //    //     <option value="State Name">State Name</option>
        //    foreach (var element in elements)
        //    {
                
        //        selectList.Add(new SelectListItem
        //        {
        //            Value = element,
        //            Text = element
        //        });
        //    }

        //    return selectList;
        //}





    }
}