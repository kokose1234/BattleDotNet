using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using BattleDotNet.Extensions;

namespace BattleDotNet.JsonConverters
{
    public class JavaScriptTimeStampConverter : CustomCreationConverter<DateTime>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ((long)reader.Value).ConvertJavaScriptTimestamp();
        }

        public override DateTime Create(Type objectType)
        {
            return DateTime.Now;
        }
    }
}
