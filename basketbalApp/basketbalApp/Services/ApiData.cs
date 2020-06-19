using basketbalApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace basketbalApp.Services
{
    public class ApiData  
    {
        public ApiData()
        {

        }
        public ObservableCollection<Player> players { get; set; }
        private static string baseUrl = "http://vblcb.wisseq.eu/VBLCB_WebServiceDev/data/RelatiesByOrgGuid?orgguid=";
        private static string kbbcZolder = "BVBL1081";
        private int aantalPlayers;
        public int AantalPlayers
        {
            get { return aantalPlayers; }
            set { aantalPlayers = value; }
        }

        public Player[] GetPlayers(string json)
        {
            Player[] PlayerArray = JsonConvert.DeserializeObject<Player[]>(json, Converter.Settings);
            return PlayerArray;
        }
        public string GetJson(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                return "geen internet verbinding";
                
            }
        }
        public async Task<object> GetJsonAsync(string url)
        {
            string result = await Task.Run<string>(() => GetJson(url));
            if (result == "geen internet verbinding")
            {
                return "geen internet verbinding";
            }
            else
            {
                Player[] playerArray = await Task.Run<Player[]>(() => GetPlayers(result));
                return playerArray;
            }

        }
    }
}
