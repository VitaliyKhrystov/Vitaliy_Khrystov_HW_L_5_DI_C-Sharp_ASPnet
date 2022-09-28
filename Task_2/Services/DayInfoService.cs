using Task_2.Models;

namespace Task_2.Services
{
    public static class DayInfoService
    {
        public static void AddDayInfoService(this IServiceCollection services)
        {
            services.AddScoped<DayInfo>();
            services.AddScoped<Day>();
        }
    }
}
