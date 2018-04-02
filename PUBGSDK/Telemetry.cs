using System;
using System.Net;
using PUBGSDK.JClass.Telemetry;
using PUBGSDK.Tools;

namespace PUBGSDK
{
    public class Telemetry
    {
        public JTelemetry[] GetTelemetry(string url)
        {
            var uri = new Uri(url);

            HttpStatusCode status;
            var raw_match = Request.DoRequest(uri, "", out status);

            return JTelemetry.FromJson(raw_match);
        }
    }
}