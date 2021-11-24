using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Produto
    {
        public int Id { get; set; }

        
        [DisplayName("Nome Produto")]
        [Required(ErrorMessage = "O campo Nome Produto é obrigatório")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        [Range(1, 10, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        public double Valor { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}