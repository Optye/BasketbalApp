using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace basketbalApp.Models
{
    public class Ploeg
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string nummer4 { get; set; }
        public string nummer5 { get; set; }
        public string nummer6 { get; set; }
        public string nummer7 { get; set; }
        public string nummer8 { get; set; }
        public string nummer9 { get; set; }
        public string nummer10 { get; set; }
        public string nummer11 { get; set; }
        public string nummer12 { get; set; }
        public string nummer13 { get; set; }
        public string nummer14 { get; set; }
        public string nummer15 { get; set; }

        public string naam { get; set; }
        public Ploeg(Player speler)
        {
            nummer4 = speler.FullName;
        }
        public Ploeg()
        {

        }
    }
}
