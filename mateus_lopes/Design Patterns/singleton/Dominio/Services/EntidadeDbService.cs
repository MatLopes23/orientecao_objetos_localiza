namespace singleton.Modelos.Services
{
    public class EntidadeDbService
    {
        private EntidadeDbService()
        {
            abriConexao();
        }

        private void abriConexao()
        {
            Console.WriteLine("Abrindo conexão");
        }

        private void fechar()
        {
            Console.WriteLine("Fechando conexão");
        }

        private void Salvar<T>(T obj)
        {
            Console.WriteLine($"Salvando o tipo {obj.GetType().Name}");
        }

        private static EntidadeDbService entidadeDbService;

        public static EntidadeDbService Instancia()
        {
            if(entidadeDbService == null)
            {
                entidadeDbService = new EntidadeDbService();
            }
            return entidadeDbService;
        }

        public static ClienteDbService Fechar()
        {
            entidadeDbService.fechar();
            return entidadeDbService;
        }
    }
}