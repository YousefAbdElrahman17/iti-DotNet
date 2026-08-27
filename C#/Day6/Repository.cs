 
namespace Day6
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
            {items.Add(item);}
        public bool Remove(T item)
            {return items.Remove(item);}
        public T? Find(T item)
        {
            foreach (T current in items)
            {
                if (current.Equals(item)) return current;
            }
            return default;
        }
        public T? Find(Predicate<T> match)
            {return items.Find(match);}
        public List<T> GetAll()
            {return new (items);} 
        public void Clear()
            {items.Clear();}
        public int Count()
            {return items.Count;}
    }
}