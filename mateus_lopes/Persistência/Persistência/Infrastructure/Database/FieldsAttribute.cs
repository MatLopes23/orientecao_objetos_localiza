using System;

namespace Persistência.Infrastructure.Database
{
    public class FieldsAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}
