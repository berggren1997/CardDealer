using CardDealer.Client.Services.HttpService;

namespace CardDealer.Client.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCardService(this IServiceCollection services) =>
            services.AddScoped<ICardService, CardService>();
    }
}
