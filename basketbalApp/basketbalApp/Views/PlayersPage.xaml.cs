using basketbalApp.Models;
using basketbalApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basketbalApp.Views
{
    [DesignTimeVisible(false)]
    public partial class PlayersPage : ContentPage
    {
        PlayersViewModel viewModel;
        public PlayersPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PlayersViewModel();
            InitSearchBar();
        }
        async void OnPlayerTapped(object sender, EventArgs args)
        {
            Player player = (Player)PlayersListView.SelectedItem;
            sbPlayers.Text = player.FullName;
            await Navigation.PushAsync(new PlayerDetailPage(new PlayerDetailViewModel(player)));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(PlayersListView.ItemsSource == null)
            {
                PlayersListView.BeginRefresh();
                viewModel.LoadPlayersCommand.Execute(null);
                PlayersListView.ItemsSource = viewModel.players;
                PlayersListView.EndRefresh();
            }
            else
            {
                FilterPlayer(sbPlayers.Text);
            }
        }
        void InitSearchBar()
        {
            sbPlayers.TextChanged += (s, e) => FilterPlayer(sbPlayers.Text);
            sbPlayers.SearchButtonPressed += (s, e) => FilterPlayer(sbPlayers.Text);
        }
        private void FilterPlayer(string sbText)
        {
            PlayersListView.BeginRefresh();
            if (string.IsNullOrWhiteSpace(sbText))
            {
                PlayersListView.ItemsSource = viewModel.players;
            }
            else
            {
                PlayersListView.ItemsSource = viewModel.players.Where(x => x.FullName.ToLower().Contains(sbText.ToLower()));
            }
            PlayersListView.EndRefresh();
        }

    }
}