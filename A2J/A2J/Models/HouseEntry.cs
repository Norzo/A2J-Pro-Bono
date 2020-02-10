using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace A2J.Models
{
    public class HouseEntry
    {
        [PrimaryKey, AutoIncrement]
        public int houseID { get; set; }
        public string houseAddress { get; set; }
        public int houseBedrooms { get; set; }
        public int houseRent { get; set; }
    }
}
