using System.Linq;
using BasisMap.Interfaces;
using BasisMap.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasisMap.Controllers
{
    public class CommoditiesController : Controller
    {
        private readonly ICommodityRepository _commodityRepository;

        public CommoditiesController(ICommodityRepository commodityRepository)
        {
            _commodityRepository = commodityRepository;
        }

        // GET: /characters/
        public IActionResult CommoditiesList()
        {
            // PopulateCharactersIfNoneExist();
            var commodities = _commodityRepository.ListAll();

            return View(commodities);
        }
        //public IActionResult CommoditiesDropDown()
        //{
        //    // PopulateCharactersIfNoneExist();
        //    var commodities = _commodityRepository.GetList();

        //    return View("_Layout", commodities);
        //}

        //private void PopulateCharactersIfNoneExist()
        //{
        //    if (!_characterRepository.ListAll().Any())
        //    {
        //        _characterRepository.Add(new Character("Darth Maul"));
        //        _characterRepository.Add(new Character("Darth Vader"));
        //        _characterRepository.Add(new Character("Yoda"));
        //        _characterRepository.Add(new Character("Mace Windu"));
        //    }
        //}
    }
}
