﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasisMap.ViewModels;
using BasisMap.Interfaces;
using BasisMap.Models.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using BasisMap.Models;
using BasisMap.DBContext;

namespace BasisMap.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ltgwarehouseContext db = new ltgwarehouseContext();
        private readonly ICommodityRepository _commodityRepository;

        public HomeController(ICommodityRepository commodityRepository)
        {
            _commodityRepository = commodityRepository;
        }
        public IActionResult Index()
        {
            // Let's get all states that we need for a DropDownList
       //     var codes = _commodityRepository.GetCommodityDropDown();

            var model = new Commodity();

            // Create a list of SelectListItems so these can be rendered on the page
            model.CommodityCodes = _commodityRepository.GetCommodityDropDown();

            return View(model);

        }









        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}