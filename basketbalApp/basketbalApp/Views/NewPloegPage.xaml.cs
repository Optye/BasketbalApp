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
    public partial class NewPloegPage : ContentPage
    {
        PloegDetailViewModel viewModel;
        private int change = 0;
        public NewPloegPage(PloegDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;

            var OnTappedPlayer = new TapGestureRecognizer();
            OnTappedPlayer.Tapped += AddPlayerLabel;
            Nummer4Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer5Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer6Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer7Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer8Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer9Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer10Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer11Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer12Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer13Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer14Label.GestureRecognizers.Add(OnTappedPlayer);
            Nummer15Label.GestureRecognizers.Add(OnTappedPlayer);

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(viewModel.verwijderd == true)
            {
                switch (change)
                {
                    case 4:
                        Nummer4Label.IsVisible = false;
                        Nummer4Button.IsVisible = true;
                        break;
                    case 5:
                        Nummer5Label.IsVisible = false;
                        Nummer5Button.IsVisible = true;
                        break;
                    case 6:
                        Nummer6Label.IsVisible = false;
                        Nummer6Button.IsVisible = true;
                        break;
                    case 7:
                        Nummer7Label.IsVisible = true;
                        Nummer7Button.IsVisible = true;
                        break;
                    case 8:
                        Nummer8Label.IsVisible = false;
                        Nummer8Button.IsVisible = true;
                        break;
                    case 9:
                        Nummer9Label.IsVisible = false;
                        Nummer9Button.IsVisible = true;
                        break;
                    case 10:
                        Nummer10Label.IsVisible = false;
                        Nummer10Button.IsVisible = true;
                        break;
                    case 11:
                        Nummer11Label.IsVisible = false;
                        Nummer11Button.IsVisible = true;
                        break;
                    case 12:
                        Nummer12Label.IsVisible = false;
                        Nummer12Button.IsVisible = true;
                        break;
                    case 13:
                        Nummer13Label.IsVisible = false;
                        Nummer13Button.IsVisible = true;
                        break;
                    case 14:
                        Nummer14Label.IsVisible = false;
                        Nummer14Button.IsVisible = true;
                        break;
                    case 15:
                        Nummer15Label.IsVisible = false;
                        Nummer15Button.IsVisible = true;
                        break;
                }
            }
            else 
            {
                switch (change)
                {
                    case 4:
                        Nummer4Label.Text = viewModel.ploeg.nummer4 = viewModel.Toevoegen.FullName;
                        Nummer4Label.IsVisible = true;
                        Nummer4Button.IsVisible = false;
                        break;
                    case 5:
                        Nummer5Label.Text = viewModel.ploeg.nummer5 = viewModel.Toevoegen.FullName;
                        Nummer5Label.IsVisible = true;
                        Nummer5Button.IsVisible = false;
                        break;
                    case 6:
                        Nummer6Label.Text = viewModel.ploeg.nummer6 = viewModel.Toevoegen.FullName;
                        Nummer6Label.IsVisible = true;
                        Nummer6Button.IsVisible = false;
                        break;
                    case 7:
                        Nummer7Label.Text = viewModel.ploeg.nummer7 = viewModel.Toevoegen.FullName;
                        Nummer7Label.IsVisible = true;
                        Nummer7Button.IsVisible = false;
                        break;
                    case 8:
                        Nummer8Label.Text = viewModel.ploeg.nummer8 = viewModel.Toevoegen.FullName;
                        Nummer8Label.IsVisible = true;
                        Nummer8Button.IsVisible = false;
                        break;
                    case 9:
                        Nummer9Label.Text = viewModel.ploeg.nummer9 = viewModel.Toevoegen.FullName;
                        Nummer9Label.IsVisible = true;
                        Nummer9Button.IsVisible = false;
                        break;
                    case 10:
                        Nummer10Label.Text = viewModel.ploeg.nummer10 = viewModel.Toevoegen.FullName;
                        Nummer10Label.IsVisible = true;
                        Nummer10Button.IsVisible = false;
                        break;
                    case 11:
                        Nummer11Label.Text = viewModel.ploeg.nummer11 = viewModel.Toevoegen.FullName;
                        Nummer11Label.IsVisible = true;
                        Nummer11Button.IsVisible = false;
                        break;
                    case 12:
                        Nummer12Label.Text = viewModel.ploeg.nummer12 = viewModel.Toevoegen.FullName;
                        Nummer12Label.IsVisible = true;
                        Nummer12Button.IsVisible = false;
                        break;
                    case 13:
                        Nummer13Label.Text = viewModel.ploeg.nummer13 = viewModel.Toevoegen.FullName;
                        Nummer13Label.IsVisible = true;
                        Nummer13Button.IsVisible = false;
                        break;
                    case 14:
                        Nummer14Label.Text = viewModel.ploeg.nummer14 = viewModel.Toevoegen.FullName;
                        Nummer14Label.IsVisible = true;
                        Nummer14Button.IsVisible = false;
                        break;
                    case 15:
                        Nummer15Label.Text = viewModel.ploeg.nummer15 = viewModel.Toevoegen.FullName;
                        Nummer15Label.IsVisible = true;
                        Nummer15Button.IsVisible = false;
                        break;
                }
            }
            nameEntry.Text = viewModel.ploeg.naam;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }
        private void AddPlayer(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.ClassId)
            {
                case "Nummer4Button":
                    change = 4;
                    break;
                case "Nummer5Button":
                    change = 5;
                    break;
                case "Nummer6Button":
                    change = 6;
                    break;
                case "Nummer7Button":
                    change = 7;
                    break;
                case "Nummer8Button":
                    change = 8;
                    break;
                case "Nummer9Button":
                    change = 9;
                    break;
                case "Nummer10Button":
                    change = 10;
                    break;
                case "Nummer11Button":
                    change = 11;
                    break;
                case "Nummer12Button":
                    change = 12;
                    break;
                case "Nummer13Button":
                    change = 13;
                    break;
                case "Nummer14Button":
                    change = 14;
                    break;
                case "Nummer15Button":
                    change = 15;
                    break;
            }
            Navigation.PushAsync(new PlayersPage(viewModel));
        }
        private void AddPlayerLabel(object s, EventArgs e)
        {
            var label = (Label)s;
            switch (label.ClassId)
            {
                case "Nummer4Button":
                    change = 4;
                    break;
                case "Nummer5Button":
                    change = 5;
                    break;
                case "Nummer6Button":
                    change = 6;
                    break;
                case "Nummer7Button":
                    change = 7;
                    break;
                case "Nummer8Button":
                    change = 8;
                    break;
                case "Nummer9Button":
                    change = 9;
                    break;
                case "Nummer10Button":
                    change = 10;
                    break;
                case "Nummer11Button":
                    change = 11;
                    break;
                case "Nummer12Button":
                    change = 12;
                    break;
                case "Nummer13Button":
                    change = 13;
                    break;
                case "Nummer14Button":
                    change = 14;
                    break;
                case "Nummer15Button":
                    change = 15;
                    break;
            }
            Navigation.PushAsync(new PlayersPage(viewModel));
        }
        private void Opslaan(object sender, EventArgs e)
        {
            viewModel.ploeg.naam = nameEntry.Text;
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Ploeg>();
                conn.Insert(viewModel.ploeg);
            }
            Navigation.PopAsync();

        }
    }
}