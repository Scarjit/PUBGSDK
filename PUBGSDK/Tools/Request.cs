using System;
using System.IO;
using System.Net;

namespace PUBGSDK.Tools
{
    internal class Request
    {
        public static string DoRequest(Uri url, out HttpStatusCode status_code, string key = "")
        {
            var request = WebRequest.Create(url);
            if (key != "")
            {
                request.Headers.Add("Authorization", "Bearer " + key);
            }

            request.Headers.Add("Accept", "application/vnd.api+json");
            request.Method = "GET";


            WebResponse wr = null;
            try
            {
                wr =
                    request.GetResponse();
                status_code = ((HttpWebResponse) wr).StatusCode;
            }
            catch (Exception e)
            {
                if (wr != null)
                {
                    status_code = ((HttpWebResponse) wr).StatusCode;
                    return string.Empty;
                }

                Console.WriteLine(e);
                throw;
            }

            string resp;


            using (var s = wr.GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    resp = sr.ReadToEnd();
                }
            }

            return resp;
        }
    }
}