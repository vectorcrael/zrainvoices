using System;
using DataLayer.Models2;
using VSDCAPI;

namespace VSDCAPIApiClient
{
    public class DataMapper
    {

        public static class DeviceDetails
        {
            public static string Tpin { get; set; } = "1002546945";
            public static string BhfId { get; set; } = "000";
            public static string DvcSrlNo { get; set; } = "CHC-EVO";
        }

        public static SaveSalesRequest ConvertInvoice(ZraInvoice zraInvoice)
        {
            SaveSalesRequest invoice = new SaveSalesRequest
            {
                BhfId = DeviceDetails.BhfId,
                Tpin = DeviceDetails.Tpin,
                OrgInvcNo = (int)zraInvoice.OriginalInvoiceNumber,
                CisInvcNo = zraInvoice.InvoiceNumber,
                CustTpin = zraInvoice.CustomerTpin,
                CustNm = zraInvoice.CustomerName,
                //SalesTyCd =zraInvoice.,
                RcptTyCd = zraInvoice.ReceiptTypeCode,
                PmtTyCd = zraInvoice.PaymentTypeCode,
                //SalesSttsCd =zraInvoice.,
                //CfmDt =zraInvoice.,
                SalesDt = zraInvoice.SaleDate.ToString(),
                //StockRlsDt =zraInvoice.,
                //CnclReqDt =zraInvoice,
                //CnclDt =zraInvoice.,
                //RfdDt =zraInvoice.,
                RfdRsnCd = zraInvoice.RefundReasonCode,
                //TotItemCnt =zraInvoice.,
                //TaxblAmtA =zraInvoice.,
                //TaxblAmtB =zraInvoice.,
                //TaxblAmtC1 =zraInvoice.,
                //TaxblAmtC2 =zraInvoice.,
                //TaxblAmtC3 =zraInvoice.,
                //TaxblAmtD =zraInvoice.,
                //TaxblAmtRvat =zraInvoice.,
                //TaxblAmtE =zraInvoice.,
                //TaxblAmtF =zraInvoice.,
                //TaxblAmtIpl1 =zraInvoice.,
                //TaxblAmtIpl2 =zraInvoice.,
                //TaxblAmtTl =zraInvoice.,
                //TaxblAmtEcm =zraInvoice.,
                //TaxblAmtExeeg =zraInvoice.,
                //TaxblAmtTot =zraInvoice.,
                //TaxRtA =zraInvoice.,
                //TaxRtB =zraInvoice.,
                //TaxRtC1 =zraInvoice.,
                //TaxRtC2 =zraInvoice.,
                //TaxRtC3 =zraInvoice.,
                //TaxRtD =zraInvoice.,
                //TlAmt =zraInvoice.,
                //TaxRtRvat =zraInvoice.,
                //TaxRtE =zraInvoice.,
                //TaxRtF =zraInvoice.,
                //TaxRtIpl1 =zraInvoice.,
                //TaxRtIpl2 =zraInvoice.,
                //TaxRtTl =zraInvoice.,
                //TaxRtEcm =zraInvoice.,
                //TaxRtExeeg =zraInvoice.,
                //TaxRtTot =zraInvoice.,
                //TaxAmtA =zraInvoice.,
                //TaxAmtB =zraInvoice.,
                //TaxAmtC1 =zraInvoice.,
                //TaxAmtC2 =zraInvoice.,
                //TaxAmtC3 =zraInvoice.,
                //TaxAmtD =zraInvoice.,
                //TaxAmtRvat =zraInvoice.,
                //TaxAmtE =zraInvoice.,
                //TaxAmtF =zraInvoice.,
                //TaxAmtIpl1 =zraInvoice.,
                //TaxAmtIpl2 =zraInvoice.,
                //TaxAmtTl =zraInvoice.,
                //TaxAmtEcm =zraInvoice.,
                //TaxAmtExeeg =zraInvoice.,
                //TaxAmtTot =zraInvoice.,
                //TotTaxblAmt =zraInvoice.,
                //TotTaxAmt =zraInvoice.,
                //TotAmt =zraInvoice.,
                //PrchrAcptcYn =zraInvoice.,
                //Remark =zraInvoice.,
                RegrId = zraInvoice.RefundReasonCode,
                //RegrNm =zraInvoice.,
                //ModrId =zraInvoice.,
                //ModrNm =zraInvoice.,
                //SaleCtyCd =zraInvoice.,
                LpoNumber = zraInvoice.LocalPurchaseOrder,
                CurrencyTyCd = zraInvoice.CurrencyType,
                //ExchangeRt =zraInvoice.,
                DestnCountryCd = zraInvoice.DestinationCountryCode,
                //DbtRsnCd =zraInvoice.,
                //InvcAdjustReason =zraInvoice
            };

            invoice.ItemList = new List<ItemList3>();

            foreach (var item in zraInvoice.Items)
            {
                invoice.ItemList.Add(new ItemList3
                {
                    ItemSeq = item.ItemSequenceNumber,
                    ItemCd = item.ItemCode,
                    ItemClsCd = item.ItemClassificationCode!.ToString(),
                    ItemNm = item.RefId,
                    //Bcd = item. ,
                    PkgUnitCd = item.PackagingUnitCode!.ToString(),
                    //Pkg = item. ,
                    QtyUnitCd = item.QuantityUnitCode!.ToString(),
                    Qty = (double)item.Quantity,
                    Prc = (int)item.RRP,
                    //SplyAmt = item. ,
                    //DcRt = item. ,
                    //DcAmt = item. ,
                    IsrccCd = item.IsTaxInclusive.ToString(),
                    //IsrccNm = item.,
                    //IsrcRt = item. ,
                    //IsrcAmt = item. ,
                    //VatCatCd = item. ,
                    //ExciseTxCatCd = item,
                    TlCatCd = item.TaxLabel,
                    //IplCatCd = item.,
                    //VatTaxblAmt = item. ,
                    //VatAmt = item. ,
                    //ExciseTaxblAmt = item.,
                    //TlTaxblAmt = item. ,
                    //IplTaxblAmt = item. ,
                    //IplAmt = item. ,
                    //TlAmt = item,
                    //ExciseTxAmt = item. ,
                    TotAmt = (int)item.TotalAmount
                });
            };

            return invoice;
        }

        public static UpdateItemRequest MapToUpdateItemRequest(ItemList3 item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            return new UpdateItemRequest
            {
                ItemCd = item.ItemCd,
                ItemClsCd = item.ItemClsCd,
                ItemNm = item.ItemNm,
                PkgUnitCd = item.PkgUnitCd,
                QtyUnitCd = item.QtyUnitCd,
                VatCatCd = item.VatCatCd,
                IplCatCd = item.IplCatCd,
                TlCatCd = item.TlCatCd,
                ExciseTxCatCd = item.ExciseTxCatCd,
                Bcd = item.Bcd,
                DftPrc = item.Prc, 
                Tpin = DeviceDetails.Tpin,
                BhfId = DeviceDetails.BhfId,
                ItemTyCd = null,
                ItemStdNm = null,
                OrgnNatCd = null,
                BtchNo = null,
                AddInfo = null,
                SftyQty = 0, 
                IsrcAplcbYn = null,
                UseYn = null,
                RegrNm = null,
                RegrId = null,
                ModrNm = null,
                ModrId = null
            };
        }
    }
}

