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

        public string relguid4 { get; set; }
        public string relguid5 { get; set; }
        public string relguid6 { get; set; }
        public string relguid7 { get; set; }
        public string relguid8 { get; set; }
        public string relguid9 { get; set; }
        public string relguid10 { get; set; }
        public string relguid11 { get; set; }
        public string relguid12 { get; set; }
        public string relguid13 { get; set; }
        public string relguid14 { get; set; }
        public string relguid15 { get; set; }

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
