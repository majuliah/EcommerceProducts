﻿
using Ecommerce.Controllers;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TestCategory
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id = 1, NomeCategoria = "Teste Categoria" };
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

             await service.Details(1); 

            _mockSet.Verify(m => m.FindAsync(1),
                Times.Once());
        }

        [Fact]
        public async Task Put_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.Edit(1, _categoria);

            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Fact]
        public async Task Post_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.Create(_categoria);

            _mockSet.Verify(x => x.Add(_categoria), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Fact]
        public async Task Delete_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);
            await service.Delete(1);

            _mockSet.Verify(m => m.FindAsync(1),
                Times.Once());
            _mockSet.Verify(x => x.Remove(_categoria), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()),
                Times.Once());
        }
    }
}
    

