using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BattleDotNet.JsonConverters
{
    public class JavaScriptTimeStampConverter : CustomCreationConverter<DateTime>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            long timestamp = ((long)reader.Value) / 1000;
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0);

            return epoch.AddSeconds(timestamp);
        }

        public override DateTime Create(Type objectType)
        {
            return DateTime.Now;
        }
    }
}
