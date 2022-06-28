using System.Collections.Generic;

namespace ExportExcellSheetFeature.Models
{
    public class FakecData
    {
       
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }


        public List<FakecData> GetFakeData()
        {

            List<FakecData> data = new List<FakecData>() {
            new FakecData { FirstName ="sdf"  , LastName = "sd"  , Email = "ads@MDSFK" , Gender ="fEMAIL" , MobileNo = "0112014463" , Status = "true" , UserName ="sdfs"} ,
            new FakecData { FirstName ="sdf"  , LastName = "sd"  , Email = "ads@MDSFK" , Gender ="fEMAIL" , MobileNo = "0112014463" , Status = "true" , UserName ="sdfs"} ,
            new FakecData { FirstName ="sdf"  , LastName = "sd"  , Email = "ads@MDSFK" , Gender ="fEMAIL" , MobileNo = "0112014463" , Status = "true" , UserName ="sdfs"} ,
            new FakecData { FirstName ="sdf"  , LastName = "sd"  , Email = "ads@MDSFK" , Gender ="fEMAIL" , MobileNo = "0112014463" , Status = "true" , UserName ="sdfs"} ,
            };

            return data;

        }
        public List<FakecData> GetEmptyData()
        {

            List<FakecData> data = new List<FakecData>();

            return data;

        }
    }
}