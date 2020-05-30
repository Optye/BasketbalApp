using basketbalApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace basketbalApp.ViewModels
{
    public class PloegDetailViewModel : BaseViewModel
    {
        private Ploeg ploeg;
        public Ploeg Ploeg
        {
            get { return this.ploeg; }
            set { this.SetPropertyValue(ref this.ploeg, value); }
        }
        public Player Toevoegen;
        public bool verwijderd = false;
        public PloegDetailViewModel(Ploeg ploeg)
        {
            this.Ploeg = ploeg;
        }
        public PloegDetailViewModel()
        {
            ploeg = new Ploeg();
            Toevoegen = new Player();
        }
    }
}
