using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.Models
{
    public partial class Player
    {
        public int id { get; set; }
        [JsonProperty("relGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string RelGuid { get; set; }

        [JsonProperty("naam", NullValueHandling = NullValueHandling.Ignore)]
        public string Naam { get; set; }

        [JsonProperty("vnaam", NullValueHandling = NullValueHandling.Ignore)]
        public string Vnaam { get; set; }

        [JsonProperty("gebdat", NullValueHandling = NullValueHandling.Ignore)]
        public string Gebdat { get; set; }

        [JsonProperty("mvo", NullValueHandling = NullValueHandling.Ignore)]
        public string Mvo { get; set; }

        [JsonProperty("cat", NullValueHandling = NullValueHandling.Ignore)]
        public string Cat { get; set; }

        [JsonProperty("maOrg", NullValueHandling = NullValueHandling.Ignore)]
        public string MaOrg { get; set; }

        [JsonProperty("orguid1", NullValueHandling = NullValueHandling.Ignore)]
        public string Orguid1 { get; set; }

        [JsonProperty("orgLMS", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgLms { get; set; }

        private string fullname;

        public string FullName
        {
            get {
                fullname = Vnaam + " " + Naam;
                return fullname; }
            set { fullname = value; }
        }

    }


}
