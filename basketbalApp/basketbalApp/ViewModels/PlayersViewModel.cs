using basketbalApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace basketbalApp.ViewModels
{
    public class PlayersViewModel : BaseViewModel
    {
        private string baseUrl = "http://vblcb.wisseq.eu/VBLCB_WebServiceDev/data/RelatiesByOrgGuid?orgguid=";
        private string kbbcZolder = "BVBL1081";
        public ObservableCollection<Player> players { get; set; }
        public Command LoadPlayersCommand { get; set; }
        private string waarBenIk;
        public string WaarBenIk
        {
            get { return this.waarBenIk; }
            set { this.SetPropertyValue(ref this.waarBenIk, value); }
        }
        private string aantalPlayers;
        public string AantalPlayers
        {
            get { return this.aantalPlayers; }
            set { this.SetPropertyValue(ref this.aantalPlayers, value); }
        }

        public PlayersViewModel()
        {
            Title = "Spelers";
            WaarBenIk += "playerviewmodel";
            players = new ObservableCollection<Player>();
            LoadPlayersCommand = new Command(async () => await ExecuteLoadPlayersCommand());
            WaarBenIk += " playerviewmodel";
            /*string json = GET(baseUrl + kbbcZolder);
            players = JsonConvert.DeserializeObject<Player[]>(json, Converter.Settings);*/
        }
        private async Task<Player[]> GetJsonAsync(string url)
        {
            string result = await Task.Run<string>(() => GetJson(url));
            WaarBenIk += " Json";
            Player[] playerArray = await Task.Run<Player[]>(() => GetPlayers(result));
            WaarBenIk += " playersArray";
            return playerArray;

        }
        private Player[] GetPlayers(string json)
        {
            Player[] PlayerArray = JsonConvert.DeserializeObject<Player[]>(json, Converter.Settings);
            return PlayerArray;
        }
        private static string GetJson(string url)
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
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }

        }
        async Task ExecuteLoadPlayersCommand()
        {
            IsBusy = true;

            try
            {
                players.Clear();
                WaarBenIk += " executePlayersCommand";
                var playersArray = await GetJsonAsync(baseUrl + kbbcZolder);
                //var playersArray = GetPlayers(GetJson(baseUrl + kbbcZolder)); 
                foreach (var player in playersArray)
                {
                    players.Add(player);
                }
                AantalPlayers = Convert.ToString(players.Count());
                WaarBenIk += " ObservableCollection";

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
