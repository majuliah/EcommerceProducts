using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
    }
}
