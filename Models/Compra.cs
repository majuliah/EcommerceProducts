using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Compra
    {

        public int Id { get; set; }
        [Display(Name = "Descrição")]

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public int ProdutoId { get; set; }

        public Produto Produto { get; set; }

    }
}