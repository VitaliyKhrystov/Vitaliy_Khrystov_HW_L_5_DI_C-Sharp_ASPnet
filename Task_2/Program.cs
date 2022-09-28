using Task_2.Models;
using Task_2.Services;

namespace Task_2
{
    public class Program
    {

        //������� 1
        //�������� ����������, ������� ������� ������������ ������ ��������� ��������.��������
        //��� �������, ���� ������� ������������� ������ �������� ���� ������, ������, �������
        //������������� ������ � �������� �������.���������� ����� DI �������� ����������� ������
        //�� ��������, ������������ ������ ������� �� �������� DI.

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDayInfoService();
            builder.Services.AddMonthInfoService();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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