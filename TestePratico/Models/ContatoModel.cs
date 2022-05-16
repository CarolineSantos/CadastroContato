using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestePratico.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o telefone residencial")]
        public string Telefone { get; set; }
        public string Celular { get; set; }

    }
}

//namespace TestePratico.Models
//{
//    public class ContatosModels
//    {
//        //[Display(Name = "Result")]
//        public List<ContatoModel> Contatos { get; set; }
//    }
//}

namespace TestePratico.Models
{
    public class ContatoViewModel
    {
        public ContatoModel Registro { get; set; }
        public List<ContatoModel> Lista { get; set; }
    }
}