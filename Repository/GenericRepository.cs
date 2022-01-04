using WireBrainCoffee.StorageApp;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WireBrainCoffee
{
    public class GenericRepository<T> where T:EntityBase
    {
        private readonly List<T> _items = new();
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add (T item)
        {
            _items.Add(item);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}