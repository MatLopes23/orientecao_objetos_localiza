using System.Collections.Generic;
using System.Reflection;

namespace DataBase
{
    public class GenericMap
    {
        public static string Builder<T>(T dado)
        {
            var nome = $"{dado.GetType().Name.ToLower()}s";
            var tabela = dado.GetType().GetCustomAttribute<TabelaAttribute>();

            if(tabela != null && !string.IsNullOrEmpty(tabela.Nome))
            {
                nome = tabela.Nome;
            }

            var campos = dado.GetType().GetProperties();

            var sql = $"insert into {nome} values (";
            List<string> colunasDb = new List<string>();

            foreach (var campo in campos)
            {
                var campoPersistido = campo.GetCustomAttribute<CampoPersistidoAttribute>();
                if (campoPersistido != null)
                {
                    var nomeCampo = string.IsNullOrEmpty(campoPersistido.NomeColuna) ? campo.Name : campoPersistido.NomeColuna;
                    colunasDb.Add(nomeCampo);
                }
            }

            sql += string.Join(",", colunasDb.ToArray());
            sql += ")";

            return sql;

        }
    }
}
