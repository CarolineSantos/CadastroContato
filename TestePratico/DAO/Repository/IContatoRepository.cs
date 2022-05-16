using System.Collections.Generic;
using TestePratico.Models;

namespace TestePratico.Repository
{
    public interface IContatoRepository
    {
        List<ContatoModel> ListaContatos();

        ContatoModel AdicionarContato(ContatoModel contato);

        bool ExcluirContato(int id);
    }
}
