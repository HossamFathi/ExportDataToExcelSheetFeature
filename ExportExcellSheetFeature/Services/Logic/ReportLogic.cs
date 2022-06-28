using ExportExcellSheetFeature.Controllers;
using ExportExcellSheetFeature.Models;
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
    }
}
