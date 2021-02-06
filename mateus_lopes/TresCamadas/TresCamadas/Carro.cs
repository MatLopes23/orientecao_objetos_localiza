using DataBase;

namespace TresCamadas
{
    public class Carro : IBase
    {
        [Pk]
        public int Id { get; set; }

        [CampoPersistido]
        public string Nome { get; set; }
        [CampoPersistido]
        public string Telefone { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
    }
}
