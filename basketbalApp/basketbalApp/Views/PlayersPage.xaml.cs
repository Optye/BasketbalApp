﻿using basketbalApp.Models;
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
        bool ToevoegModus = false;
        PloegDetailViewModel ploegDetailViewModel;
        public PlayersPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PlayersViewModel();
            InitSearchBar();
        }
        public PlayersPage(PloegDetailViewModel ploegenModel)
        {
            InitializeComponent();
            ToevoegModus = true;
            ToolbarItem item = new ToolbarItem();
            item.Text = "delete";
            item.Clicked += Delete;
            ToolbarItems.Add(item);
            BindingContext = viewModel = new PlayersViewModel();
            ploegDetailViewModel = ploegenModel;
            InitSearchBar();
        }

        protected override bool OnBackButtonPressed()
        {
            if (ToevoegModus)
            {
                DeleteItem();
            }
            
            return base.OnBackButtonPressed();
            
        }
        protected async void Delete(object sender, EventArgs e)
        {
            DeleteItem();
        }
        private async void DeleteItem()
        {
            ploegDetailViewModel.Toevoegen = null;
            ploegDetailViewModel.verwijderd = true;
            await Navigation.PopModalAsync();
        }

        protected async void OnPlayerTapped(object sender, EventArgs args)
        {
            Player player = (Player)PlayersListView.SelectedItem;
            if (ToevoegModus)
            {
                ploegDetailViewModel.verwijderd = false;
                ploegDetailViewModel.Toevoegen = player;
                await Navigation.PopModalAsync();
                
            }
            else if (player.FullName == " geen internet verbinding")
            {
            }
            else
            {
                sbPlayers.Text = player.FullName;
                await Navigation.PushAsync(new PlayerDetailPage(new PlayerDetailViewModel(player)));
            }
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
        protected void InitSearchBar()
        {
            sbPlayers.TextChanged += (s, e) => FilterPlayer(sbPlayers.Text);
            sbPlayers.SearchButtonPressed += (s, e) => FilterPlayer(sbPlayers.Text);
        }
        protected void FilterPlayer(string sbText)
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