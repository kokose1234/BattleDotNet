using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace BattleDotNet.Utilities
{
    public class BattleNetTime
    {
        private static readonly DateTime _dateBaseline = new DateTime(1970, 1, 1);
        private static long? _serverTimeDiff = null;

        /// <summary>
        /// The current difference in time between the local time and Battle.net's time.
        /// </summary>
        public static long ServerTimeDiff
        {
            get
            {
                if (!_serverTimeDiff.HasValue)
                {
                    try
                    {
                        WebClient client = new WebClient();
                        byte[] responseData = client.DownloadData("http://m.us.mobileservice.blizzard.com/enrollment/time.htm");
                        byte[] response = null;

                        using (MemoryStream ms = new MemoryStream())
                        {
                            using (Stream bs = new MemoryStream(responseData))
                            {
                                byte[] temp = new byte[64];
                                int read;
                                while ((read = bs.Read(temp, 0, 64)) != 0)
                                {
                                    ms.Write(temp, 0, read);
                                }
                                response = ms.ToArray();

                                // Verify the Responsa Data's length is 8
                                if (response.Length != 8)
                                {
                                    throw new Exception("The response data's length was not 8.");
                                }
                            }
                        }
                        if (BitConverter.IsLittleEndian == true)
                        {
                            Array.Reverse(response);
                        }
                        long currentTime = Convert.ToInt64((DateTime.UtcNow - _dateBaseline).TotalMilliseconds);
                        long serverTimeDiff = BitConverter.ToInt64(response, 0) - currentTime;
                        _serverTimeDiff = serverTimeDiff;

                    }
                    catch
                    {
                        throw;
                    }
                }

                return _serverTimeDiff.Value;
            }
        }
    }
}