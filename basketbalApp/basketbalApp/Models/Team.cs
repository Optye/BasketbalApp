using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.Models
{
    public partial class Team
    {
        public int id { get; set; }
        [JsonProperty("teamGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamGuid { get; set; }

        [JsonProperty("naam", NullValueHandling = NullValueHandling.Ignore)]
        public string Naam { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        [JsonProperty("speelNivo", NullValueHandling = NullValueHandling.Ignore)]
        public long? SpeelNivo { get; set; }
    }
}
