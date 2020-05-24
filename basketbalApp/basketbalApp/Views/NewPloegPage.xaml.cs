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
    public partial class NewPloegPage : ContentPage
    {
        PloegDetailViewModel viewModel;
        public NewPloegPage(PloegDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.ploeg.nummer4 == null)
            {
                name.IsVisible = false;
            }
        }
    }
}