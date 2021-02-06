using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataBase
{
    public class CarroDbService
    {
        public static void Salvar(IBase iBase)
        {
            Console.WriteLine($"Estou salvando o carro");
            var campos = iBase.GetType().GetProperties();

            var sql = $"insert into {iBase.GetType().Name.ToLower()}s values (";
            List<string> colunasDb = new List<string>();

            foreach(var campo in campos)
            {
                var campoPersistido = campo.GetCustomAttribute<CampoPersistidoAttribute>();
                if(campoPersistido != null)
                {
                    colunasDb.Add(campo.Name);
                }
            }

            sql += string.Join(",", colunasDb.ToArray());
            sql += ")";

            Console.WriteLine(sql);
        }
    }
}
