using ExportExcellSheetFeature.Models;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExportExcellSheetFeature.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReport _IReporting;
        public ReportController(IReport IReporting)
        {
            _IReporting = IReporting;


        }
        public IActionResult Index()
        {
            var list = _IReporting.GetUserwiseReport();
            return View(list);
        }
        
        public IActionResult DownloadData()
        {

            string reportname = $"User_Wise_{Guid.NewGuid():N}.xlsx";
            var list = _IReporting.GetUserwiseReport();
            if (list.Count > 0)
            {
                var exportbytes = ExporttoExcel<FakecData>(list, reportname);
                return File(exportbytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", reportname);
            }
            else
            {
                TempData["Message"] = "No Data to Export";
                return View();
            }
        }

        private byte[] ExporttoExcel<T>(List<T> table, string filename)
        {
            using ExcelPackage pack = new ExcelPackage();
            ExcelWorksheet ws = pack.Workbook.Worksheets.Add(filename);
            ws.Cells["A1"].LoadFromCollection(table, true, TableStyles.Light1);
            return pack.GetAsByteArray();
        }
    }
}
