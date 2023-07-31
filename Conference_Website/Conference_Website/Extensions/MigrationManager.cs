using Conference_Website.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Conference_Website.Extension
{
    public  static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();

                    ContextSeed.SeedAsync(context).Wait();
                }
                catch (Exception e)
                {

                }
            }
            return host;
        }
    }
}
