using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.Models
{
    public static class Serialize
    {
        public static string ToJson(this Player[] self) => JsonConvert.SerializeObject(self, basketbalApp.Models.Converter.Settings);
    }
}
