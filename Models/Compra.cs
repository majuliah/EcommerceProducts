using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Compra
    {

        public int Id { get; set; }
<<<<<<< HEAD
        [Display(Name = "Descrição")]

=======
        [DisplayName("Descrição da Compra")]
>>>>>>> c11b7b6b488147c0a00e1b0491171bdb54b99e39
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }

        [DisplayName("Cliente")]
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        [DisplayName("Nome Produto")]
        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

    }
}