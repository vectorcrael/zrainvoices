using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class BranchUserRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string UserId { get; set; }
        public string UserNm { get; set; }
        public string Adrs { get; set; }
        public string UseYn { get; set; }
        public string RegrNm { get; set; }
        public string RegrId { get; set; }
        public string ModrNm { get; set; }
        public string ModrId { get; set; }
    }
}