using singleton.Modelos.Services

namespace singleton.Dominio.UseCase
{
    public class EntidadeUseCase
    {
        public static void Salvar<T>(T entidade)
        {
            EntidadeDbService.Instancia().Salvar(entidade);
            EntidadeSmsService.Instancia().Enviar(entidade);
            EntidadeMailService.Instancia().Enviar(entidade);
        }
    }
}