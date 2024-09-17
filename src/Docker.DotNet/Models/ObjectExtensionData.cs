using Newtonsoft.Json;
using System.Collections.Generic;

namespace Docker.DotNet.Models
{
    public class ObjectExtensionData
    {
        [JsonExtensionDataAttribute]
        public IDictionary<string, object> ExtensionData { get; set; }
    }
}