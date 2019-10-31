using SQLite;

using System;
using System.Collections.Generic;
using System.Text;

namespace projsqllite
{
    public class database
    {
        //lấy thư mục lưu trữ csdl trên hệ thống
        string folder = System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
        public bool createDatabase()
        {
            try
            {
                //tạo csdl
                using (var connection = new
                 SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tạo 2 bang
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InsertLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        
        //Xử lý Thêm Hoa
        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool DELETE(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Hoa> selecthoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
       
        public List<Loaihoa> selectLoaihoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }

    }
}

