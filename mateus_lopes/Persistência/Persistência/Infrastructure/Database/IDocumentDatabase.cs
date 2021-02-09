using System.Collections.Generic;

namespace Persistência.Infrastructure.Database
{
    public interface IDocumentDatabase
    {
        void Save<T>(T obj);

        List<T> All<T>();

        void Remove<T>(T obj);
    }
}
