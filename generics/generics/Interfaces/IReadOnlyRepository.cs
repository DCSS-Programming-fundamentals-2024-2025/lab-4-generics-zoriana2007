namespace generics.Interfaces
{
    public interface IReadOnlyRepository<out TEntity, in TKey>
    {
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
    }
}