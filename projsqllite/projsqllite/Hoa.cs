using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace projsqllite
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public string Mahoa { get; set; }
        public string Maloai { get; set; }
        public string Tenhoa { get; set; }
        public string Hinh { get; set; }
        public string Mota { get; set; }
        public string Gia { get; set; }
    }
}
