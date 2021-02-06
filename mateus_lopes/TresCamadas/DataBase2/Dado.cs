using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public abstract class Dado : IBase
    {
        [Pk]
        public int Id { get; set; }

        public abstract void Salvar();
    }
}
