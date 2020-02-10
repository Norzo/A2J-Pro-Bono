using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using A2J.Models;
using SQLite;
using System.IO;

namespace A2J.Data
{
    public static class HouseDatabase
    {
        private static SQLiteAsyncConnection _database = null ;

        public static Task<List<HouseEntry>> getHousesAsync()
        {
            return  getdb().Table<HouseEntry>().ToListAsync();
        }

        public static Task<int> saveHouseAsync(HouseEntry house)
        {
            return  getdb().InsertAsync(house); 
        }

        private static SQLiteAsyncConnection getdb()
        {
            if (_database == null)
            {
                _database = new SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Houses.db3"));
                _database.CreateTableAsync<HouseEntry>().Wait();

            }
            return  _database;
        }

    }


}
