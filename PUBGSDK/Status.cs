using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PUBGSDK.JClass.Matches;
using PUBGSDK.JClass.Status;
using PUBGSDK.Tools;

namespace PUBGSDK
{
    public class Status
    {

        public Tuple<JStatus, Request.ResponseInfo> GetStatus()
        {
            var uri = new Uri(URL.base_url + URL.status);

            HttpStatusCode status;
            int requestsRemaining;
            var raw_match = Request.DoRequest(uri, "", true, false, false);

            return new Tuple<JStatus, Request.ResponseInfo>(JStatus.FromJson(raw_match.response), raw_match);
        }
    }
}
