using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuracao
{
    public class ContextFactory : IDesignTimeDbContextFactory<ContextBase>
    {
        public ContextBase CreateDbContext(string[] args)
        {
            // Configuração para migrações
            var optionsBuilder = new DbContextOptionsBuilder<ContextBase>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7T5EKEK;Initial Catalog=FINANCEIRO_2025;Integrated Security=False;User ID=sa;Password=admin123@;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True"); // substitua pela sua string

            return new ContextBase(optionsBuilder.Options);
        }
    }
}
