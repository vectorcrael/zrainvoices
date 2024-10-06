using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class UpdateItemRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemTyCd { get; set; }
        public string ItemNm { get; set; }
        public string ItemStdNm { get; set; }
        public string OrgnNatCd { get; set; }
        public string PkgUnitCd { get; set; }
        public string QtyUnitCd { get; set; }
        public string VatCatCd { get; set; }
        public string IplCatCd { get; set; }
        public object TlCatCd { get; set; }
        public object ExciseTxCatCd { get; set; }
        public object BtchNo { get; set; }
        public object Bcd { get; set; }
        public int DftPrc { get; set; }
        public object AddInfo { get; set; }
        public int SftyQty { get; set; }
        public string IsrcAplcbYn { get; set; }
        public string UseYn { get; set; }
        public string RegrNm { get; set; }
        public string RegrId { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
    }
}