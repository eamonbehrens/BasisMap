using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasisMap.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BasisMap.Controllers
{
    public class BasisValuesInput : Controller
    {
        // GET: /<controller>/
        public IActionResult BasisValues()
        {
            return View(new Commodity());
        }
    }
}
