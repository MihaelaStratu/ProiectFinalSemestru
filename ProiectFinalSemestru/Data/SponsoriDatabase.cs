using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ProiectFinalSemestru.Models;

namespace ProiectFinalSemestru.Data
{
    public class SponsorDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public SponsorDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Sponsor>().Wait();
            _database.CreateTableAsync<Speaker>().Wait();
            _database.CreateTableAsync<Partener>().Wait();
            _database.CreateTableAsync<Categorie>().Wait();
            _database.CreateTableAsync<Evenimente>().Wait();
        }
        public Task<List<Sponsor>> GetSponsorAsync()
        {
            return _database.Table<Sponsor>().ToListAsync();
        }
        public Task<Sponsor> GetSponsorAsync(int id)
        {
            return _database.Table<Sponsor>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveSponsorAsync(Sponsor slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteSponsorAsync(Sponsor slist)
        {
            return _database.DeleteAsync(slist);
        }
        public Task<List<Speaker>> GetSpeakerAsync()
        {
            return _database.Table<Speaker>().ToListAsync();
        }
        public Task<Speaker> GetSpeakerAsync(int id)
        {
            return _database.Table<Speaker>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveSpeakerAsync(Speaker speaker)
        {
            if (speaker.ID != 0)
            {
                return _database.UpdateAsync(speaker);
            }
            else
            {
                return _database.InsertAsync(speaker);
            }
        }
        public Task<int> DeleteSpeakerAsync(Speaker speaker)
        {
            return _database.DeleteAsync(speaker);
        }
        public Task<List<Partener>> GetPartenerAsync()
        {
            return _database.Table<Partener>().ToListAsync();
        }
        public Task<Partener> GetPartenerAsync(int id)
        {
            return _database.Table<Partener>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SavePartenerAsync(Partener partener)
        {
            if (partener.ID != 0)
            {
                return _database.UpdateAsync(partener);
            }
            else
            {
                return _database.InsertAsync(partener);
            }
        }
        public Task<int> DeletePartenerAsync(Partener partener)
        {
            return _database.DeleteAsync(partener);
        }
        public Task<List<Categorie>> GetCategorieAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }
        public Task<Categorie> GetCategorieAsync(int id)
        {
            return _database.Table<Categorie>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCategorieAsync(Categorie categorie)
        {
            if (categorie.ID != 0)
            {
                return _database.UpdateAsync(categorie);
            }
            else
            {
                return _database.InsertAsync(categorie);
            }
        }
        public Task<int> DeleteCategorieAsync(Categorie categorie)
        {
            return _database.DeleteAsync(categorie);
        }

        public Task<List<Evenimente>> GetEvenimenteAsync()
        {
            return _database.Table<Evenimente>().ToListAsync();
        }
        public Task<Evenimente> GetEvenimenteAsync(int id)
        {
            return _database.Table<Evenimente>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveEvenimenteAsync(Evenimente evenimente)
        {
            if (evenimente.ID != 0)
            {
                return _database.UpdateAsync(evenimente);
            }
            else
            {
                return _database.InsertAsync(evenimente);
            }
        }
        public Task<int> DeleteEvenimenteAsync(Evenimente evenimente)
        {
            return _database.DeleteAsync(evenimente);
        }
        
    }

}

