using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveItemCompositionRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string ItemCd { get; set; }
        public string CpstItemCd { get; set; }
        public int CpstQty { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
    }
}