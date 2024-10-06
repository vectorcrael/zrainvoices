using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SavePurchasesRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public int InvcNo { get; set; }
        public int OrgInvcNo { get; set; }
        public string SpplrTpin { get; set; }
        public string SpplrBhfId { get; set; }
        public string SpplrNm { get; set; }
        public string SpplrInvcNo { get; set; }
        public string RegTyCd { get; set; }
        public string PchsTyCd { get; set; }
        public string RcptTyCd { get; set; }
        public string PmtTyCd { get; set; }
        public string PchsSttsCd { get; set; }
        public string CfmDt { get; set; }
        public string PchsDt { get; set; }
        public string CnclReqDt { get; set; }
        public string CnclDt { get; set; }
        public int TotItemCnt { get; set; }
        public double TotTaxblAmt { get; set; }
        public double TotTaxAmt { get; set; }
        public double TotAmt { get; set; }
        public string Remark { get; set; }
        public string RegrNm { get; set; }
        public string RegrId { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
        public List<ItemList2> ItemList { get; set; }
    }

    public class ItemList2
    {
        public int ItemSeq { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemNm { get; set; }
        public object Bcd { get; set; }
        public string PkgUnitCd { get; set; }
        public int Pkg { get; set; }
        public string QtyUnitCd { get; set; }
        public int Qty { get; set; }
        public int Prc { get; set; }
        public int SplyAmt { get; set; }
        public int DcRt { get; set; }
        public int DcAmt { get; set; }
        public string TaxTyCd { get; set; }
        public object IplCatCd { get; set; }
        public object TlCatCd { get; set; }
        public double TaxblAmt { get; set; }
        public string VatCatCd { get; set; }
        public object IplTaxblAmt { get; set; }
        public object TlTaxblAmt { get; set; }
        public double TaxAmt { get; set; }
        public double TotAmt { get; set; }
    }
}