using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public static List<CityClass> cities = new List<CityClass>()
        {
            new CityClass()
            {
                CityID = 1,
                CityName = "Kayseri",
                CityCountry="Türkiye"
            },
            new CityClass()
            {
                CityID= 2,
                CityCountry="İngiltere",
                CityName="Londra"

            },
            new CityClass()
            {
                CityID=3,
                CityName="Roma",
                CityCountry="İtalya"
            }
        };
    }
}
