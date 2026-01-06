namespace PizzaCs.Infrastructure.Repository.Interfaces;

public interface IBaseRepository<T>
{
    Task<T?> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task CreateAsync(T entity);
    //Task CreateAsync(List<T> entity);
    //void Update(T entity);
    //void Delete(T entity);
    void SaveChanges();
}
