using Task_2.Models;

namespace Task_2.Services
{
    public static class MonthInfoService
    {
        public static void AddMonthInfoService(this IServiceCollection services)
        {
            services.AddScoped<MonthInfo>();
            services.AddScoped<Month>();
        }
    }
}
