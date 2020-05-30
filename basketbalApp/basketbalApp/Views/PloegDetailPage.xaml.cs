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
    }
}