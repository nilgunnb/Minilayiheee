using PizzaMizza.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Data.Repositories.BaseRepositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        private readonly List<T> _items = new List<T>();

        public async Task CreateAsync(T model)
        {
            _items.Add(model);
        }

        public async Task DeleteAsync(T model)
        {
            _items.Remove(model);
        }

        public async Task<T> GetAsync(int id, Predicate<T> func)
        {
            return _items.Find(func);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return _items;
        }
    }


    
}
