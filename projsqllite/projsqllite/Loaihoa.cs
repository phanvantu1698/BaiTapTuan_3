using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace projsqllite
{
    public class Loaihoa
    {
        [PrimaryKey, AutoIncrement]
        public string Maloai { get; set; }
        public string Tenloai { get; set; }
    }
}

