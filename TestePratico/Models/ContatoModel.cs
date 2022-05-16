using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestePratico.Models
{
    public class ContatoModel
    {
        public int Id { get; private set; }
        [Required(ErrorMessage = "Informe o nome", AllowEmptyStrings = false)]
        public string Nome { get; private set; }
        [Required(ErrorMessage = "Informe o telefone residencial", AllowEmptyStrings = false)]
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
    }
}
