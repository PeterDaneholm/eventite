namespace ConsoleAppTest.repositories;

public interface IRepository<T>
{
    public void Add(T entity, Guid userId);
    
}