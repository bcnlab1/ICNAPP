using ICNAPP.DataAccess.CSAccess.Interface;
using ICNAPP.DataAccess.PITAccess.Interface;
using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
namespace ICNAPP.DataAccess.PITAccess.Repository
{
    public class PITRepository : IPITRepository
    {
        MemoryCache Cache = MemoryCache.Default;
        public static readonly double TimeToExpireInSecondsDefault;
        static PITRepository()
        {
            TimeToExpireInSecondsDefault = 4; // default PIT expiry time
        }

        public void Add(PITEntry pITEntries)
        {
            Insert(pITEntries.InterestName, pITEntries, TimeToExpireInSecondsDefault);
        }

        public void Delete(PITEntry pITEntries)
        {
            Remove(pITEntries.InterestName);
        }

        public void Edit(PITEntry pITEntries)
        {
            Remove(pITEntries.InterestName);
            Insert(pITEntries.InterestName, pITEntries, TimeToExpireInSecondsDefault);
        }

        public List<PITEntry> GetAll()
        {
            throw new NotImplementedException();
        }

        public PITEntry GetBy(int id)
        {
            return (PITEntry)Get(id.ToString());
        }

        public PITEntry GetBy(string name)
        {
            return (PITEntry)Get(name);
        }



        private void Insert(string key, object value, double timeToExpireInSeconds)
        {
            Cache.Add(key, value, DateTime.Now.AddSeconds(timeToExpireInSeconds));
        }
        

        private object Get(string key)
        {
            return Cache[key];
        }

        private object Get<T>(string key) where T : class
        {
            return Cache[key] as T;
        }

        private bool Has(string key)
        {
            return (Cache[key] != null);
        }
        private void Remove(string key)
        {
            Cache.Remove(key);
        }

    }
}



