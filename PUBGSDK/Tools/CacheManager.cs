using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PUBGSDK.Tools
{
    class CacheManager
    {
        private SQLiteConnection dbConnection;
        private string db_name = "pubg_sdk_cache.sqlite3";
        public CacheManager()
        {
            dbConnection = new SQLiteConnection("Data Source="+ db_name+";Version=3");
            dbConnection.Open();
            
            string query = "CREATE TABLE IF NOT EXISTS cache (url TEXT, response TEXT, status TEXT);";
            SQLiteCommand cmd = new SQLiteCommand(query, dbConnection);
            cmd.ExecuteNonQuery();
        }

        ~CacheManager()
        {
            dbConnection.Close();
        }


        private string query_lookup = "SELECT * FROM cache WHERE url = @url";
        public bool IsInCache(Uri url)
        {
            SQLiteCommand lookupCommand = new SQLiteCommand(query_lookup, dbConnection);
            lookupCommand.Parameters.AddWithValue("@url", url.ToString());

            bool cached = false;
            using (SQLiteDataReader rdr = lookupCommand.ExecuteReader())
            {
                while (rdr.Read())
                {
                    cached = true;
                    break;
                }
            }
            
            if (cached)
            {
                Console.WriteLine("Cache hit [" + url + "]");
            }
            else
            {
                Console.WriteLine("Cache miss [" + url + "]");
            }

            return cached;
        }

        public Tuple<string, HttpStatusCode> GetCached(Uri url)
        {
            SQLiteCommand lookupCommand = new SQLiteCommand(query_lookup, dbConnection);
            lookupCommand.Parameters.AddWithValue("@url", url.ToString());

            string resp = null;
            HttpStatusCode status = 0;
            using (SQLiteDataReader rdr = lookupCommand.ExecuteReader())
            {
                while (rdr.Read())
                {
                    resp = rdr.GetString(1);
                    Enum.TryParse(rdr.GetString(2), out status);
                    break;
                }
            }
            

            return new Tuple<string, HttpStatusCode>(resp, status);
        }

        private string query_insert = "INSERT INTO cache (url, response, status) VALUES (@url, @response, @status)";
        public void InsertIntoCache(Uri url, string resp, HttpStatusCode status)
        {
            SQLiteCommand lookupCommand = new SQLiteCommand(query_insert, dbConnection);
            lookupCommand.Parameters.AddWithValue("@url", url.ToString());
            lookupCommand.Parameters.AddWithValue("@response", resp);
            lookupCommand.Parameters.AddWithValue("@status", status.ToString());

            lookupCommand.ExecuteNonQuery();
        }
    }
}
