using System.Collections.Generic;
using System.Reflection;

namespace DataBase
{
    public class Map
    {
        public static string Builder(IBase iBase)
        {
            var campos = iBase.GetType().GetProperties();

            var sql = $"insert into {iBase.GetType().Name.ToLower()}s values (";
            List<string> colunasDb = new List<string>();

            foreach (var campo in campos)
            {
                var campoPersistido = campo.GetCustomAttribute<CampoPersistidoAttribute>();
                if (campoPersistido != null)
                {
                    colunasDb.Add(campo.Name);
                }
            }

            return sql;

        }
    }
}
