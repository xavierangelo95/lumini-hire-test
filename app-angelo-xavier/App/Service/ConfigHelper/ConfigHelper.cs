
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Service.Helpers
{
    public static class ConfigHelper
    {
        private static readonly IConfiguration configuration = CreateBuilder();

        private static IConfiguration CreateBuilder()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }

        public static bool TryGet<TOutput>(string name, out TOutput output)
        {
            output = default;

            var exists = configuration.GetSection(name).Exists();
            if (exists) output = configuration.GetSection(name).Get<TOutput>();

            return exists;
        }




    }
}
