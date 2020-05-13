using basketbalApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.ViewModels
{
    public class PlayerDetailViewModel : BaseViewModel
    {
        public Player Player { get; set; }
        public PlayerDetailViewModel(Player player)
        {
            Player = player;
            Title = Player.FullName;
        }
    }
}
