using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.DAO;
using TestePratico.Models;

namespace TestePratico.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepository(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel AdicionarContato(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();//comita

            return contato;
        }

        public List<ContatoModel> ListaContatos() 
        {
            return _bancoContext.Contatos.ToList();//carrega toda lista
        }

        private ContatoModel ContatoProId(int id) 
        {
            List<ContatoModel> contatos = ListaContatos();
            var contato = contatos.SingleOrDefault(c => c.Id == id);
            return contato;
        }

        public bool ExcluirContato(int id)
        {
            var contato = ContatoProId(id);

            if (contato == null)
                throw new System.Exception("Erro ao deletar contato.");

            _bancoContext.Contatos.Remove(contato);
            _bancoContext.SaveChanges();//comita
            return true;
        }
    }
}
