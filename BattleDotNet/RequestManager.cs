using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;

namespace BattleDotNet
{
    public class RequestManager
    {
        public RequestManager()
        {
        }

        public string GetContent(string url)
        {
            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            
            // Use GZip/Delfate when possible
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            
            // This will help with speed by keeping the internal connection
            // pool on a per-thread basis
            webRequest.ConnectionGroupName = Thread.CurrentThread.ManagedThreadId.ToString();

            // Will help with speed by not having to check for automatic settings
            webRequest.Proxy = null;

            // Give some information
            webRequest.UserAgent = "BattleDotNet C# Library | http://github.com/ChadMoran/BattleDotNet";

            using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
            {
                using (Stream responseStream = webResponse.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}