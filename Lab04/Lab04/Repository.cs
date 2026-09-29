using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    public class Repository<T> where T : class, IEntity
    {
        private readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            if (Exists(item.Id))
                throw new InvalidOperationException($"Id '{item.Id}' da ton tai trong repository.");

            items.Add(item);
        }

        public bool Remove(string id)
        {
            T? item = FindById(id);
            return item != null && items.Remove(item);
        }

        public bool Exists(string id)
        {
            return FindById(id) != null;
        }

        public T? FindById(string id)
        {
            return items.FirstOrDefault(x =>
                string.Equals(x.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            return items.Where(predicate).ToList();
        }

        public List<T> GetAll()
        {
            return new List<T>(items);
        }
    }
}
