using System;

namespace singleton.Modelos.Services
{
    public class EntidadeSmsService
    {
        private EntidadeSmsService() { }

        public void Enviar<T>(T obj)
        {
            Console.WriteLine($"Enviando SMS do tipo {obj.GetType().Name}");
        }

        private static EntidadeSmsService entidadeSmsService;

        public static EntidadeSmsService Instancia()
        {
            if (entidadeSmsService == null) entidadeSmsService = new EntidadeSmsService();
            return entidadeSmsService;
        }

        public static void Fechar()
        {
            entidadeSmsService = null;
        }
    }
}