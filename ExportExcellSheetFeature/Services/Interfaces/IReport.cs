using ExportExcellSheetFeature.Models;
using System.Collections.Generic;

namespace ExportExcellSheetFeature.Controllers
{
    public interface IReport
    {
        List<FakecData> GetUserwiseReport();
        byte[] ExporttoExcel<T>(List<T> table, string filename);

    }
}