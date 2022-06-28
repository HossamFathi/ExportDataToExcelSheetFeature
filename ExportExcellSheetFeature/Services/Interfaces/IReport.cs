using ExportExcellSheetFeature.Models;
using System.Collections.Generic;

namespace ExportExcellSheetFeature.Controllers
{
    public interface IReport
    {
        List<FakecData> GetUserwiseReport();

    }
}