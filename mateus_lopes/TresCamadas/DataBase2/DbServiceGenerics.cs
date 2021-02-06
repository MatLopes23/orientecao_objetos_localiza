using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataBase
{
    public class DbServiceGenerics
    {
        public static void Salvar<T>(T dado)
        {
            Console.WriteLine($"Estou salvando o carro");

            var sql = GenericMap.Builder<T>(dado);

            Console.WriteLine(sql);
        }
    }
}
