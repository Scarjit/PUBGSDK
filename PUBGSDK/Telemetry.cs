using System;
using System.Net;
using PUBGSDK.JClass.Telemetry;
using PUBGSDK.Tools;

namespace PUBGSDK
{
    public class Telemetry
    {
        public Tuple<JTelemetry[], Request.ResponseInfo> GetTelemetry(string url)
        {
            var uri = new Uri(url);

            HttpStatusCode status;
            int requestsRemaining;
            var raw_match = Request.DoRequest(uri);
            
            return new Tuple<JTelemetry[], Request.ResponseInfo>(JTelemetry.FromJson(raw_match.response), raw_match);
        }
    }
}