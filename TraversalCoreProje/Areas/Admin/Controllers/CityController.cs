using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }


        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityID=1,
                CityName="Üsküp",
                CityCountry="Makedonya"
            },
            new CityClass
            {
                CityID=2,
                CityName="Roma",
                CityCountry="İtalya"
            },
            new CityClass
            {
                CityID=3,
                CityName="Londra",
                CityCountry="İngiltere"
            }
        };
    }
}
