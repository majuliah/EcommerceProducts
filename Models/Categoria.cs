using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace MVCapp.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }   

        public List<Produto> Produtos { get; set; }

    }
}
