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
            if (Player.Mvo == "M")
            {
                Player.Mvo = "Man";
            }
            else if (Player.Mvo == "V")
            {
                Player.Mvo = "Vrouw";
            }
            else if (Player.Mvo == "O")
            {
                Player.Mvo = "Ongekend";
            }
        }
    }
}
