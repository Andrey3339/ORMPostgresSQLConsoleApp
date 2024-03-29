public class App<T>
    where T : Worker
{
    IRepository<T> current;
    public App(IRepository<T> repo) => current = repo; 

    public void Create(T item) => current.Create(item);
    public void Update(int id, T modified) => current.Update(id, modified);
    public void Remove(int id) => current.Delete(id);

    public void Print() => Console.WriteLine(String.Join<T>('\n', current.Read()));

    public void PPrint() 
    { 
        PostgresRepository p = (PostgresRepository) current;
        Console.WriteLine(String.Join<NewWorker>('\n', p.ReadNameAndId(2)));
    }


}

