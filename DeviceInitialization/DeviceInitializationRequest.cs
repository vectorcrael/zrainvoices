using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VSDCAPI
{
    public class DeviceInitializationRequest
    {
        public string Tpin { get; set; }
        public string BhfId { get; set; }
        public string DvcSrlNo { get; set; }
    }
}