using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "O campo Categoria é obrigatório")]
        public string NomeCategoria { get; set; }
    }
}
