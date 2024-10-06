using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class UpdateImportItemsRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string TaskCd { get; set; }
        public string DclDe { get; set; }
        public List<ImportItemList> ImportItemList { get; set; }
    }

    public class ImportItemList
    {
        public int ItemSeq { get; set; }
        public string HsCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemCd { get; set; }
        public string ImptItemSttsCd { get; set; }
        public string Remark { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
    }
}