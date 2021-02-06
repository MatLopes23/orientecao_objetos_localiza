using DataBase;

namespace TresCamadas
{
    [Tabela(Nome = "tbl_carros")]
    public class Carro : IBase
    {
        [Pk]
        public int Id { get; set; }

        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }
        [CampoPersistido]
        public string Telefone { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
    }
}
