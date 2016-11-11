using System.Linq;
using BasisMap.Interfaces;
using BasisMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewModels.CommodityViewModel model = new ViewModels.CommodityViewModel();
            model.CommodityCodes = new SelectList(_commodityRepository.ListAll());
           // var commodities = _commodityRepository.ListAll();

            return View(model);
        }

    }
}
