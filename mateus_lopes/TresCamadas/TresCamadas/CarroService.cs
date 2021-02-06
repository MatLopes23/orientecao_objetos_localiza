using DataBase;
using System;

namespace Negocio
{
    public class CarroService
    {
        public static void Salvar(IBase iBase)
        {
            Console.WriteLine("Estou salvando o carro");

            DbServiceGenerics.Salvar(iBase);
        }
    }
}
