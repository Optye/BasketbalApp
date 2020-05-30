using basketbalApp.Models;
using basketbalApp.ViewModels;
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
    public partial class PlayerDetailPage : ContentPage
    {
        PlayerDetailViewModel PlayerDetailViewModel;
        public PlayerDetailPage(PlayerDetailViewModel PlayerDetailViewModel)
        {
            InitializeComponent();
            BindingContext = this.PlayerDetailViewModel = PlayerDetailViewModel;

        }
        public PlayerDetailPage()
        {
            var player = new Player();
            PlayerDetailViewModel = new PlayerDetailViewModel(player);
            BindingContext = PlayerDetailViewModel;
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
    }
}