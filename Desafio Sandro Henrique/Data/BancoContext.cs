using Desafio_Sandro_Henrique.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Sandro_Henrique.Data
{
    public class BancoContext : DbContext 
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {  
        }

        public DbSet<ClientesModel> Clientes { get; set; }

        public DbSet<FornecedoresModel> Fornecedores { get; set; }
    }
}
