using Blazor.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Blazor.Infrastructure
{
    public class AppDbContextSeed
    {
        public static async Task Seed(
            AppDbContext appDbContext,
            ILogger logger)
        {
            if (appDbContext.Database.IsMySql())
                await appDbContext.Database.MigrateAsync();
        }
    }
}
