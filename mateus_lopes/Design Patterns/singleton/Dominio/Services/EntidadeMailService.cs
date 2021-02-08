namespace singleton.Modelos.Services
{
    public class EntidadeMailService
    {
        private EntidadeMailService() { }

        public void Enviar<T>(T obj)
        {
            Console.WriteLine($"Enviando email para o tipo {obj.GetType().Name}");
        }

        private static EntidadeMailService entidadeMailService;

        public static EntidadeMailService Instancia()
        {
            if (entidadeMailService == null) entidadeMailService = new EntidadeMailService();
            return entidadeSmsService;
        }

        public static void Fechar()
        {
            entidadeMailService = null;
        }
    }
}