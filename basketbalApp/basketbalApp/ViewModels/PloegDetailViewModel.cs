using basketbalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.ViewModels
{
    public class PloegDetailViewModel
    {
        public Ploeg ploeg;
        public PloegDetailViewModel(Ploeg ploeg)
        {
            this.ploeg = ploeg;
        }
        public PloegDetailViewModel()
        {
            ploeg = new Ploeg();
        }
    }
}
