using System;

namespace STRATEGY.Modelos.Implementado
{
    public interface IPessoa
    {
        int Id { get; set; }

        string Nome { get; set; }

        string Telefone { get; set; }

        string Email { get; set; }
         
    }
}