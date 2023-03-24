using FilmKatalogusAPI.Data;
using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;

namespace FilmKatalogusAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddScoped<IGenericRepository<Film>, GenericRepository<Film, FilmContext>>();
            builder.Services.AddScoped<IGenericRepository<Szinesz>, GenericRepository<Szinesz, FilmContext>>();
            builder.Services.AddDbContext<FilmContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}