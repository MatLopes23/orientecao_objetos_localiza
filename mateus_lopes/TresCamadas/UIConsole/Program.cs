using Negocio;
using System;
using TresCamadas;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro()
            {
                Id = 1,
                Nome = "Mateus",
                Telefone = "123456",
                Ano = 2021,
                Descricao = "Teste"
            };
            CarroService.Salvar(carro);
        }
    }
}
