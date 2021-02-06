using Negocio;
using TresCamadas;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new Carro()
            {
                Nome = "Mateus",
                Telefone = "123456",
                Ano = 2021,
                Descricao = "Teste"
            }.Salvar();
            //CarroService.Salvar(carro);
        }
    }
}
