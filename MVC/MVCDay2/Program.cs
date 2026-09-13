namespace MVCDay2
{
    public class Program
    {

        /*
        http://localhost:5152/home/welcome
        http://localhost:5152/home/GetAllemps
        http://localhost:5152/home/GetempWithid?id=1
        
        */

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=home}/{action=Welcome}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}