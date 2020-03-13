using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCondominio.Models
{
    public class Sala
    {
        public long Id { get; set; }
        public int Salas { get; set; }
        public int Andar { get; set; }
        public int Garagem { get; set; }
    }
}