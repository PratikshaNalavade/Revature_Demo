using System.Collections.Generic;

public class InMemoryRepository<T> : IRepository<T>
{
    private readonly Dictionary<int, T> _storage = new();
    private int _currentId = 0;

    public void Add(T item)
    {
        _storage[++_currentId] = item;
    }

    public IEnumerable<T> GetAll()
    {
        return _storage.Values;
    }

    public T GetById(int id)
    {
        if (!_storage.ContainsKey(id))
            throw new KeyNotFoundException("Item not found");

        return _storage[id];
    }
}
