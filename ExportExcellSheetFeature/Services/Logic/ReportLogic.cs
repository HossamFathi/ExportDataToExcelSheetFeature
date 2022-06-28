using ExportExcellSheetFeature.Controllers;
using ExportExcellSheetFeature.Models;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExportExcellSheetFeature.Services.Logic
{
    public class ReportLogic : IReport
    {
        public List<FakecData> GetUserwiseReport()
        {
            FakecData data = new FakecData();

            //test case if is Found data 
            return data.GetFakeData();
            // test case If Not Found data
            //return data.GetEmptyData();
        }

        public byte[] ExporttoExcel<T>(List<T> table, string filename)
        {
            using ExcelPackage pack = new ExcelPackage();
            ExcelWorksheet ws = pack.Workbook.Worksheets.Add(filename);
            ws.Cells["A1"].LoadFromCollection(table, true, TableStyles.Light1);
            return pack.GetAsByteArray();
        }
    }
}
