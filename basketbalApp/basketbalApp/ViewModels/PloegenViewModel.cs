using basketbalApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.ViewModels
{
    public class PloegenViewModel : BaseViewModel
    {
        public List<Ploeg> ploegen;
        public PloegenViewModel()
        {
            Title = "Ploegen";

        }
        public void Refresh()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Ploeg>();
                ploegen = conn.Table<Ploeg>().ToList();
            }
        }
    }
}
