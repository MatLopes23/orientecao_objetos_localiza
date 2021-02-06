using Database;

namespace TresCamadas
{
    public class Carro : IBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
    }
}
