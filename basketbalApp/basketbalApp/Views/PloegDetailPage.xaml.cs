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
    public partial class PloegDetailPage : ContentPage
    {
        PloegDetailViewModel viewModel;
        public PloegDetailPage(PloegDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        async void DeleteListItem(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.Delete(viewModel.Ploeg);
            }
            await Navigation.PopAsync();
        }
        protected override void OnAppearing()
        {
            if (viewModel.Ploeg.nummer4 == null)
            {
                lay4.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer5 == null)
            {
                lay5.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer6 == null)
            {
                lay6.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer7 == null)
            {
                lay7.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer8 == null)
            {
                lay8.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer9 == null)
            {
                lay9.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer10 == null)
            {
                lay10.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer11 == null)
            {
                lay11.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer12 == null)
            {
                lay12.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer13 == null)
            {
                lay13.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer14 == null)
            {
                lay14.IsVisible = false;
            }
            if (viewModel.Ploeg.nummer15 == null)
            {
                lay15.IsVisible = false;
            }
        }
    }
}