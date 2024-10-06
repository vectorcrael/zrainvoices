using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class BranchCustomersRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string LastReqDt { get; set; }
        public string CustNo { get; set; }
        public string CustTpin { get; set; }
        public string CustNm { get; set; }
        public object Adrs { get; set; }
        public object Email { get; set; }
        public object FaxNo { get; set; }
        public string UseYn { get; set; }
        public object Remark { get; set; }
        public string RegrNm { get; set; }
        public string RegrId { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
    }
}