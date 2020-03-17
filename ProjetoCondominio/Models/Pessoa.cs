using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoCondominio.Models
{
    public class Pessoa
    {
    private ProjetoCondominioContext db = new ProjetoCondominioContext();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    public void RemovePessoa(Pessoa pessoa)
    {
            AppContext.BaseDirectory.Remove(pessoa.Id);

    }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}