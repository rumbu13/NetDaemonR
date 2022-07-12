using NetDaemon.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassManager.Internal
{
    internal abstract class Cache<T, U> 
        where T : class  
        where U: class
    {
        bool loaded = false;
        protected Dictionary<string, T> cacheT = new();
        protected Dictionary<string, U> cacheU = new();
        protected IHomeAssistantConnection connection;

        public Cache(IHomeAssistantConnection connection)
        {
            this.connection = connection;
        }

        async Task NeedsCacheAsync()
        {
            if (!loaded)
            {
                cacheT = await LoadCacheAsync().ConfigureAwait(false);
                cacheU.Clear();
            }
            loaded = true;
        }

        protected abstract Task<Dictionary<string, T>> LoadCacheAsync();

        void FillUCache()
        {
            NeedsCacheAsync().Wait();
            if (cacheU.Count != cacheT.Count)
            {
                var keys = cacheT.Keys.Except(cacheU.Keys);
                foreach (var k in keys)
                    cacheU.Add(k, (U)Activator.CreateInstance(typeof(U), this, cacheT[k])!);
            }
        }

        public U? Get(string id)
        {
            NeedsCacheAsync().Wait();
            if (cacheU.TryGetValue(id, out var resultU))
                return resultU;
            else if (cacheT.TryGetValue(id, out var resultT))
            {
                resultU = (U)Activator.CreateInstance(typeof(U), this, resultT)!;
                cacheU.Add(id, resultU);
                return resultU;
            }
            return null;               
        }

        public IEnumerable<U> Get()
        {
            FillUCache();
            return cacheU.Values;
        }

        public void Invalidate()
        {
            loaded = false;
            cacheU.Clear();
            cacheT.Clear();
        }

        internal void Update(string id, T valueT, U valueU)
        {
            cacheT[id] = valueT;
            cacheU[id] = valueU;
        }

        internal void Remove(string id)
        {
            cacheU.Remove(id);
            cacheT.Remove(id);
        }

        internal void Append(string id, T valueT, U valueU)
        {
            cacheT.Add(id, valueT);
            cacheU.Add(id, valueU);
        }

        
    }
}
