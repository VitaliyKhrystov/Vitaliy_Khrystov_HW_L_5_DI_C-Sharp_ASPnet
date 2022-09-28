using Task1.Models;

namespace Task1
{
    public class Program
    {

        //Задание (Additional Task)
        //Создайте класс с методами для арифметических операций с именем CalcService.Создайте
        //контроллер, который будет содержать методы действия для арифметических операций.
        //Настройте DI таким образом, чтобы контроллер воспользовался сервисом CalcService.


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICalc<double>, Calc>();
            builder.Services.AddScoped<Value<double>>();

           
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}