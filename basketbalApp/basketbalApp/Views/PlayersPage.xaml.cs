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
        }
        async void OnPlayerTapped(object sender, EventArgs args)
        {
            //var layout = (BindableObject)sender;
            //var item = (Item)layout.BindingContext;
            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.players.Count == 0)
                viewModel.LoadPlayersCommand.Execute(null);
        }
    }
}