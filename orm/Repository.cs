using System;

    // public interface IWorkerRepository
    // {
    //     void Create(Worker item);
    //     Worker[] Read();
    //     void Update(int id, Worker newItem);
    //     void Delete(int id);
    // }

    public interface IRepository<T>
    {
        void Create(T item);
        T[] Read();
        void Update(int id, T newItem);
        void Delete(int id);

    }
