using System;

namespace STRATEGY.Modelos.Implementado
{
    public class Juridica : IPessoa, IJuridica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public void Salvar(){
            Console.WriteLine("Salvo no banco de dados pessoa juridica");
        } 
    }
}