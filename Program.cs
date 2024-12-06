using BUMS.Services;
using BUMS.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BUMS;

namespace BUMS{
    public class Program{
        public static void Main(string[] args){
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("BUMSAuthConnection") ?? throw new InvalidOperationException("Connection string 'BUMSAuthConnection' not found.");

            // Add services to the container.
            builder.Services.AddRazorPages(options => 
                    options.Conventions.AuthorizePage("/CreateUser","Admin"));
            builder.Services.AddTransient<IGroupService, GroupService>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<IUserGroupService, UserGroupService>();

            builder.Services.AddAuthorization(options =>
                    options.AddPolicy("Admin", policy =>
                        policy.RequireAuthenticatedUser()
                        .RequireClaim("IsAdmin", bool.TrueString)));

            builder.Services.AddDbContext<BUMSDbContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BUMSDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()){
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
