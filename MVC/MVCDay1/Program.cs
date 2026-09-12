namespace MVCDay1
{
    public class Program
    {
        
        /*
        MVC (model view controller)
         - Model: has db, classes..etc
         - View: ui html
         - controller: receive requests when an action happens
        data seeding insert data in db context
        .Net, Asp.net Core web app (MVC) not ConsoleApp or Razor
        cd/project
        Add packages (EFCore)
        Make sure of new db name
        dotnet build
        dotnet ef migrations add migName
        dotnet ef database update
        dotnet run, cancle by ctrl+c
        close all run by (pkill -9 -f dotnet)
        (dotnet watch run: Auto Reload & Rebuild) after edits
        After Run, take Port code from terminal
        Now listening on: https://localhost:7XXX
        Now listening on: http://localhost:5076
        https://localhost:{PORT}/Employee/GetAll
        https://localhost:PORT/Employee/add?Name=Osama&Age=27&Salary=5200&DeptId=1
        https://localhost:PORT/Employee/update?Id=1&Name=JohnUpdated&Age=31&Salary=52000&DeptId=2
        https://localhost:PORT/Employee/delete?id=1    
        */

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
               pattern: "{controller=Home}/{action=Index}/{id?}")
              //pattern: "{controller=Employee}/{action=GetAll}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}