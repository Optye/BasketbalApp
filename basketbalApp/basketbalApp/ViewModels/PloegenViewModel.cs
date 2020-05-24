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
        public void RandomMockData()
        {
            Player speler1 = new Player();
            speler1.Naam = "joske";
            speler1.id = 2;
            speler1.Mvo = "m";
            Ploeg test = new Ploeg(speler1);
            test.naam = "frans";
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Ploeg>();
                int rowsAdded = conn.Insert(test);
            }
        }
    }
}
