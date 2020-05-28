using basketbalApp.Models;
using basketbalApp.Services;
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
        public string AantalPlayers;



        public PlayersViewModel()
        {
            Title = "Spelers";
            WaarBenIk += "playerviewmodel";
            players = new ObservableCollection<Player>();
            LoadPlayersCommand = new Command(async () => await ExecuteLoadPlayersCommand());
            WaarBenIk += " playerviewmodel";
            
        }
        public void SetAantal()
        {
            //AantalPlayers = App;
        }

        async Task ExecuteLoadPlayersCommand()
        {
            IsBusy = true;

            try
            {
                players.Clear();
                WaarBenIk += " executePlayersCommand";
                var result = await App.apiData.GetJsonAsync(baseUrl + kbbcZolder);
                if (result == "geen internet verbinding")
                {
                    Player player = new Player { Naam = "geen internet verbinding" };
                    players.Add(player);
                }
                else
                {
                    var playersArray = (Player[])result;
                    foreach (var player in playersArray)
                    {
                        players.Add(player);
                    }
                }

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
