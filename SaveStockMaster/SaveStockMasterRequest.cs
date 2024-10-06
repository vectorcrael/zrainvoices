using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveStockMasterRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
        public List<StockItemList> StockItemList { get; set; }
    }

    public class StockItemList
    {
        public string ItemCd { get; set; }
        public int RsdQty { get; set; }
    }
}