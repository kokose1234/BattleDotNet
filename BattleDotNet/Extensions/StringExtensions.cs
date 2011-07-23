using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet.Extensions
{
    public static class StringExtensions
    {
        public static byte[] FromHex(this string target)
        {
            return
                Enumerable.Range(0, target.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(target.Substring(x, 2), 16))
                     .ToArray();
        }

        public static bool IsNullOrWhiteSpace(this string target)
        {
            return string.IsNullOrWhiteSpace(target);
        }
    }
}
