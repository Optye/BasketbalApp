using basketbalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace basketbalApp.ViewModels
{
    public class PloegDetailViewModel
    {
        public Ploeg ploeg;
        public Player Toevoegen;
        public bool verwijderd = false;


        public event PropertyChangedEventHandler PropertyChanged;

        public PloegDetailViewModel(Ploeg ploeg)
        {
            this.ploeg = ploeg;
        }
        public PloegDetailViewModel()
        {
            ploeg = new Ploeg();
            Toevoegen = new Player();
        }
    }
}
