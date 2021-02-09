using Persistência.Infrastructure.Database;

namespace Persistência.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Fields(ColumnName = "name")]
        public string Name { get; set; }
    }
}
