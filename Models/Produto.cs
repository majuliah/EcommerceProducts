using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}