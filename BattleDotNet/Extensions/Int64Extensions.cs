using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet.Extensions
{
    public static class Int64Extensions
    {
        private static DateTime NixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);

        public static DateTime ConvertJavaScriptTimestamp(this long timestamp)
        {
            timestamp = timestamp / 1000;

            return NixEpoch.AddSeconds(timestamp);
        }
    }
}
