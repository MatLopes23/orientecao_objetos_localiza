using DataBase;

namespace TresCamadas
{
    [Tabela(Nome = "tbl_carros")]
    public class Carro
    {
        [CampoPersistido(NomeColuna = "nome_carro")]
        public string Nome { get; set; }
        [CampoPersistido]
        public string Telefone { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }

        public void Salvar()
        {
            //CarroDbService.Salvar(this);
            DbServiceGenerics.Salvar<Carro>(this);
        }
    }
}
