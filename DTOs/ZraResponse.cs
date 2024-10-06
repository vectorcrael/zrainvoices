using System;
using Newtonsoft.Json;

namespace VSDCAPIApiClient.DTOs
{
	public class ZraResponse
	{
        [JsonProperty("resultCd")]
        public string ResultCd;

        [JsonProperty("resultMsg")]
        public string ResultMsg;

        [JsonProperty("resultDt")]
        public string ResultDt;

        [JsonProperty("data")]
        public object Data;   
    }
}

