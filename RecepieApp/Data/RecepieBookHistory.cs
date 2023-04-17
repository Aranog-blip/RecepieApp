using RecepieApp.Models;
using SQLite;

namespace RecepieApp.Data
{
    public class RecepieBookHistory
    {
        string _dbPath;
        private SQLiteConnection conn;

        public RecepieBookHistory(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init ()
        {
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Recepie>();
        }

        public List<Recepie> GetAll ()
        {
            Init();
            return conn.Table<Recepie>().ToList();
        }
        public void Add(Recepie recepie)
        {
            conn = new SQLiteConnection ( _dbPath );
            conn.Insert(recepie);
        }

        public void Delete(Recepie recepie)
        {
            conn = new SQLiteConnection (_dbPath);
            conn.Delete(recepie);
        }
    }
}
