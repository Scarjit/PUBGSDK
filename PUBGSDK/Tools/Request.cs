using System;
using System.IO;
using System.Net;

namespace PUBGSDK.Tools
{
    public class Request
    {
        public class ResponseInfo
        {
            /*
            X-Ratelimit-Limit
            X-Ratelimit-Remaining
            X-Ratelimit-Reset
            */

            public HttpStatusCode statusCode;
            public int X_Ratelimit_Limit = 10;
            public int X_Ratelimit_Remaining = -1;
            public int X_Ratelimit_Reset = -1;
            public bool IsFromCache;
            public string response;

        }

        private static CacheManager cm = new CacheManager();

        public static ResponseInfo DoRequest(Uri url, string key = "", bool gzip = true, bool chache_use_lookup = true, bool chache_use_save = true, bool chache_fails = false)
        {
            ResponseInfo ri = new ResponseInfo();
            

            if (chache_use_lookup && cm.IsInCache(url))
            {
                var cached = cm.GetCached(url);
                ri.IsFromCache = true;
                ri.response = cached.Item1;
                ri.statusCode = cached.Item2;
                return ri;
            }
            else
            {

                var request = (HttpWebRequest) WebRequest.Create(url);
                if (key != "")
                {
                    request.Headers.Add("Authorization", "Bearer " + key);
                }

                request.Headers.Add("Accept", "application/vnd.api+json");
                request.Method = "GET";

                if (gzip)
                {
                    request.Headers.Add("Accept-Encoding", "gzip");
                    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                }

                WebResponse wr = null;
                try
                {
                    wr =
                        request.GetResponse();

                    //Get remaining requests
                    int.TryParse(wr.Headers["X-Ratelimit-Limit"], out ri.X_Ratelimit_Limit);
                    int.TryParse(wr.Headers["X-Ratelimit-Remaining"], out ri.X_Ratelimit_Remaining);
                    int.TryParse(wr.Headers["X-Ratelimit-Reset"],out ri.X_Ratelimit_Reset);

                    ri.statusCode = ((HttpWebResponse) wr).StatusCode;
                }
                catch (Exception e)
                {
                    if (wr != null)
                    {
                        ri.statusCode = ((HttpWebResponse) wr).StatusCode;

                        if (chache_use_save && chache_fails)
                        {
                            cm.InsertIntoCache(url, ri.response, ri.statusCode);
                        }
                        
                        return ri;
                    }

                    Console.WriteLine(e);
                    throw;
                }

                using (var s = wr.GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        ri.response = sr.ReadToEnd();
                    }
                }


                if (chache_use_save)
                {
                    cm.InsertIntoCache(url, ri.response, ri.statusCode);
                }

                return ri;
            }
        }
    }
}