using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestePratico.Models;
using TestePratico.Repository;

namespace TestePratico.ViewModel
{
    public class AplicacaoRegras
    {
        private readonly IContatoRepository _contato;

        public AplicacaoRegras(IContatoRepository contato) 
        {
            _contato = contato;
        }

        public AplicacaoRegras()
        {
        }

        public ContatoModel AdicionarContato(ContatoModel contato) 
        {
            return _contato.Adicionar(contato);
        }        
    }
}
