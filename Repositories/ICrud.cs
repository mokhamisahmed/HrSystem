namespace HRSystem.Repositories
{
    public interface ICrud<T>
    {
        public Task<T> Create(T entity);

        public Task<List<T>> Read();
       
    }
}
