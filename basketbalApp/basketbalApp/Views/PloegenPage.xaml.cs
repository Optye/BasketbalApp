using basketbalApp.Models;
using basketbalApp.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace basketbalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PloegenPage : ContentPage
    {
        PloegenViewModel viewModel;
        
        public PloegenPage()
        {
            InitializeComponent();
            viewModel = new PloegenViewModel();
            BindingContext = viewModel;
            
        }
        async void AddPloeg(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewPloegPage(new PloegDetailViewModel()));
            OnAppearing();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewModel.Refresh();
            PloegenListView.ItemsSource = viewModel.ploegen;
        }
        async void OnPloegTapped(object sender, EventArgs args)
        {
            Ploeg ploeg = (Ploeg)PloegenListView.SelectedItem;
            await Navigation.PushAsync(new PloegDetailPage(new PloegDetailViewModel(ploeg)));
        }
    }
}