using System;

namespace Persistência.Infrastructure.Database
{
    public class TableAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
