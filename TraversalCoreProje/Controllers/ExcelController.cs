using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace TraversalCoreProje.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage excel= new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1,1].Value = "Rota";
            workSheet.Cells[1,2].Value = "Rehber";
            workSheet.Cells[1,3].Value = "Kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan Turu";
            workSheet.Cells[2, 2].Value = "Kadir Yıldız";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Balkan Turu";
            workSheet.Cells[3, 2].Value = "Zeynep Öztürk";
            workSheet.Cells[3, 3].Value = "30";

            var bytes=excel.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","dosya.xlsx");
            
        }
    }
}
