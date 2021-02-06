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

            var sql = Map.Builder(iBase);

            Console.WriteLine(sql);
        }
    }
}
