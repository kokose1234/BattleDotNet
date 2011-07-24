using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BattleDotNet.Extensions;

namespace BattleDotNet.JsonConverters
{
    public class IEnumerableJavaScriptTimeStampConverter : CustomCreationConverter<IEnumerable<DateTime>>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
                return null;

            ICollection<long> timestamps = new List<long>();

            while (reader.TokenType != JsonToken.EndArray)
            {
                if (reader.Read() && reader.Value != null)
                    timestamps.Add((long)reader.Value);
            }

            return timestamps.Select(t => t.ConvertJavaScriptTimestamp());
        }

        public override IEnumerable<DateTime> Create(Type objectType)
        {
            return Enumerable.Empty<DateTime>();
        }
    }
}