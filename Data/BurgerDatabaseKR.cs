using Hamburguesa_KevinRosero;
using Hamburguesa_KevinRosero.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburguesa_KevinRosero.Data
{
    public class BurgerDatabaseKR
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabaseKR(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerKR>();
        }

        public int AddNewBurger(BurgerKR burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }

        public int RemoveBurger(BurgerKR burger)
        {
            Init();
            return conn.Delete(burger);
        }


        public List<BurgerKR> GetAllBurgers()
        {
            Init();
            List<BurgerKR> burgers = conn.Table<BurgerKR>().ToList();
            return burgers;
        }

    }

}
