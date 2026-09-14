namespace MVCDay5
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

            // app.Use(async (HttpContext, next) =>
            // {
            //     await HttpContext.Response.WriteAsync("1) hello from Middleware 1\n");
            //     await next();
            //     await HttpContext.Response.WriteAsync("5) hello from Middleware 5");
            // });

            // app.Use(async (HttpContext, next) =>
            // {
            //     await HttpContext.Response.WriteAsync("2) hello from Middleware 2\n");
            //     await next();
            //     await HttpContext.Response.WriteAsync("4) hello from Middleware 4\n");
            // });

            // app.Run(async (HttpContext) =>
            // {
            //     await HttpContext.Response.WriteAsync("3) hello from Middleware 3\n");
            // });

            //Run both
            app.Map("/middleware-test", middlewareApp =>
            {
                middlewareApp.Use(async (HttpContext, next) =>
                {
                    await HttpContext.Response.WriteAsync("1) hello from Middleware 1\n");
                    await next();
                    await HttpContext.Response.WriteAsync("5) hello from Middleware 5");
                });

                middlewareApp.Use(async (HttpContext, next) =>
                {
                    await HttpContext.Response.WriteAsync("2) hello from Middleware 2\n");
                    await next();
                    await HttpContext.Response.WriteAsync("4) hello from Middleware 4\n");
                });

                middlewareApp.Run(async (HttpContext) =>
                {
                    await HttpContext.Response.WriteAsync("3) hello from Middleware 3\n");
                });
            });


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}