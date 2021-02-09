using NUnit.Framework;
using Persistência.Domain.Entities;
using Persistência.Infrastructure.Database;
using System.Data;

namespace Tdd.Infraestructure.Database
{
    public class UnitGenericMap
    {
        [Test]
        public void BuildGenericMap()
        {
            var sql = GenericMap.Builder(new Customer());
            Assert.AreEqual(sql, "insert into customers (name) values (@name)");
        }

        [Test]
        public void BuildGenericMapParameter()
        {
            var parameters = GenericMap.BuilderParameters(new Customer() {Name = "Mateus" });

            Assert.AreEqual(parameters[0].ParameterName, "@name");
            Assert.AreEqual(parameters[0].SqlDbType, SqlDbType.VarChar);
        }
    }
}