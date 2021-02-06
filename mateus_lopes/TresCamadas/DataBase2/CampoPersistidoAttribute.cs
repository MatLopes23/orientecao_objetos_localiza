using System;

namespace DataBase
{
    public class CampoPersistidoAttribute : Attribute
    {
        public string NomeColuna { get; set; }
    }
}
