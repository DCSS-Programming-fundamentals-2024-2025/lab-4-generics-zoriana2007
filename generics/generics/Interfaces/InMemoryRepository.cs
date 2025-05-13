using generics.Interfaces;

class InMemoryRepository<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : class, new() where TKey    : struct
    {
        Dictionary<TKey,TEntity> safed=new Dictionary<TKey, TEntity>();
        public void Add(TKey id,TEntity entity)
        {
           safed[id] = entity;
        }
        public void Remove(TKey id)
        {
            safed.Remove(id);
        }

        public TEntity Get(TKey id)
        {
            safed.TryGetValue(id, out var value);
            return value;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return safed.Values;
        }

   
}
