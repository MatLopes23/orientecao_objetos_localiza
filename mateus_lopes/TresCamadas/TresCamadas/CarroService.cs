﻿using Database;
using System;
using TresCamadas;

namespace Negocio
{
    public class CarroService
    {
        public static void Salvar(IBase iBase)
        {
            Console.WriteLine("Estou salvando o carro");

            CarroDbService.Salvar(iBase);
        }
    }
}
