using HealthChecks.SqlServer;
using SmartShop.API.Extensions;


/*namespace SmartShop.API.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggingConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "388dd3a277cb44c4aa128b5c899a3106";
                o.LogId = new Guid("c468b2b8-b35d-4f1a-849d-f47b60eef096");
            });

            services.AddHealthChecks()
                .AddElmahIoPublisher(options =>
                {
                    options.ApiKey = "357ce2923b5748d88171ed21f1afb8a9"; ;
                    options.LogId = new Guid("cced2116-cf91-4e12-904c-0e5db2ee1968");
                    options.HeartbeatId = "API Fornecedores";

                })
                .AddCheck("Produtos", new SqlServerHealthCheck(configuration.GetConnectionString("DefaultConnection")))
                .AddSqlServer(configuration.GetConnectionString("DefaultConnection"), name: "BancoSQL");

            services.AddHealthChecks()
                .AddSqlServerStorage(configuration.GetConnectionString("DefaultConnection"));

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }
    }
}
*/