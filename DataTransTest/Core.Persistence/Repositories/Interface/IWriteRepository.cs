﻿namespace Core.Persistence.Repositories.Interface
{
    public interface IWriteRepository<T> where T : class
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        T Delete(T entity);
        Task<T> DeleteAsync(T entity);

        //void Dispose();

    }
}
