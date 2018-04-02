using System;
using System.IO;
using System.Net;

namespace PUBGSDK.Tools
{
    internal class Request
    {
        private static CacheManager cm = new CacheManager();

        public static string DoRequest(Uri url, out HttpStatusCode status_code, string key = "", bool gzip = true, bool chache_use_lookup = true, bool chache_use_save = true, bool chache_fails = false)
        {
            if (chache_use_lookup && cm.IsInCache(url))
            {
                var cached = cm.GetCached(url);
                status_code = cached.Item2;
                return cached.Item1;
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
                string resp = null;
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

                        if (chache_use_save && chache_fails)
                        {
                            cm.InsertIntoCache(url, resp, status_code);
                        }
                        return string.Empty;
                    }

                    Console.WriteLine(e);
                    throw;
                }


                using (var s = wr.GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        resp = sr.ReadToEnd();
                    }
                }


                if (chache_use_save)
                {
                    cm.InsertIntoCache(url, resp, status_code);
                }

                return resp;
            }
        }
    }
}