using System.Collections.Generic;
using System.Reflection;

namespace DataBase
{
    public class Map
    {
        public static string Builder(IBase iBase)
        {
            var nome = $"{iBase.GetType().Name.ToLower()}s";
            var tabela = iBase.GetType().GetCustomAttribute<TabelaAttribute>();

            if(tabela != null && !string.IsNullOrEmpty(tabela.Nome))
            {
                nome = tabela.Nome;
            }

            var campos = iBase.GetType().GetProperties();

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
