using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class SaveSalesRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public int OrgInvcNo { get; set; }
        public string CisInvcNo { get; set; }
        public string CustTpin { get; set; }
        public string CustNm { get; set; }
        public string SalesTyCd { get; set; }
        public string RcptTyCd { get; set; }
        public string PmtTyCd { get; set; }
        public string SalesSttsCd { get; set; }
        public string CfmDt { get; set; }
        public string SalesDt { get; set; }
        public object StockRlsDt { get; set; }
        public object CnclReqDt { get; set; }
        public object CnclDt { get; set; }
        public object RfdDt { get; set; }
        public object RfdRsnCd { get; set; }
        public int TotItemCnt { get; set; }
        public double TaxblAmtA { get; set; }
        public double TaxblAmtB { get; set; }
        public double TaxblAmtC1 { get; set; }
        public double TaxblAmtC2 { get; set; }
        public double TaxblAmtC3 { get; set; }
        public double TaxblAmtD { get; set; }
        public double TaxblAmtRvat { get; set; }
        public double TaxblAmtE { get; set; }
        public double TaxblAmtF { get; set; }
        public double TaxblAmtIpl1 { get; set; }
        public int TaxblAmtIpl2 { get; set; }
        public double TaxblAmtTl { get; set; }
        public int TaxblAmtEcm { get; set; }
        public double TaxblAmtExeeg { get; set; }
        public double TaxblAmtTot { get; set; }
        public int TaxRtA { get; set; }
        public int TaxRtB { get; set; }
        public int TaxRtC1 { get; set; }
        public int TaxRtC2 { get; set; }
        public int TaxRtC3 { get; set; }
        public int TaxRtD { get; set; }
        public double TlAmt { get; set; }
        public int TaxRtRvat { get; set; }
        public int TaxRtE { get; set; }
        public int TaxRtF { get; set; }
        public int TaxRtIpl1 { get; set; }
        public int TaxRtIpl2 { get; set; }
        public double TaxRtTl { get; set; }
        public int TaxRtEcm { get; set; }
        public int TaxRtExeeg { get; set; }
        public int TaxRtTot { get; set; }
        public double TaxAmtA { get; set; }
        public double TaxAmtB { get; set; }
        public double TaxAmtC1 { get; set; }
        public double TaxAmtC2 { get; set; }
        public double TaxAmtC3 { get; set; }
        public double TaxAmtD { get; set; }
        public double TaxAmtRvat { get; set; }
        public double TaxAmtE { get; set; }
        public double TaxAmtF { get; set; }
        public double TaxAmtIpl1 { get; set; }
        public double TaxAmtIpl2 { get; set; }
        public double TaxAmtTl { get; set; }
        public double TaxAmtEcm { get; set; }
        public double TaxAmtExeeg { get; set; }
        public double TaxAmtTot { get; set; }
        public double TotTaxblAmt { get; set; }
        public double TotTaxAmt { get; set; }
        public int TotAmt { get; set; }
        public string PrchrAcptcYn { get; set; }
        public string Remark { get; set; }
        public string RegrId { get; set; }
        public string RegrNm { get; set; }
        public string ModrId { get; set; }
        public string ModrNm { get; set; }
        public string SaleCtyCd { get; set; }
        public object LpoNumber { get; set; }
        public string CurrencyTyCd { get; set; }
        public string ExchangeRt { get; set; }
        public string DestnCountryCd { get; set; }
        public string DbtRsnCd { get; set; }
        public string InvcAdjustReason { get; set; }

        public List<ItemList3> ItemList { get; set; }
    }

    public class ItemList3
    {
        public int ItemSeq { get; set; }
        public string ItemCd { get; set; }
        public string ItemClsCd { get; set; }
        public string ItemNm { get; set; }
        public string Bcd { get; set; }
        public string PkgUnitCd { get; set; }
        public double Pkg { get; set; }
        public string QtyUnitCd { get; set; }
        public double Qty { get; set; }
        public int Prc { get; set; }
        public int SplyAmt { get; set; }
        public double DcRt { get; set; }
        public double DcAmt { get; set; }
        public string IsrccCd { get; set; }
        public string IsrccNm { get; set; }
        public double IsrcRt { get; set; }
        public double IsrcAmt { get; set; }
        public string VatCatCd { get; set; }
        public object ExciseTxCatCd { get; set; }
        public object TlCatCd { get; set; }
        public string IplCatCd { get; set; }
        public double VatTaxblAmt { get; set; }
        public double VatAmt { get; set; }
        public int ExciseTaxblAmt { get; set; }
        public double TlTaxblAmt { get; set; }
        public double IplTaxblAmt { get; set; }
        public double IplAmt { get; set; }
        public double TlAmt { get; set; }
        public int ExciseTxAmt { get; set; }
        public int TotAmt { get; set; }
    }
}