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

        public JStatus GetStatus()
        {
            var uri = new Uri(URL.base_url + URL.status);

            HttpStatusCode status;
            var raw_match = Request.DoRequest(uri, out status);

            return JStatus.FromJson(raw_match);
        }
    }
}
