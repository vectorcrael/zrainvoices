using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class GetImportsRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string LastReqDt { get; set; }
        public string DclRefNum { get; set; }
    }
}