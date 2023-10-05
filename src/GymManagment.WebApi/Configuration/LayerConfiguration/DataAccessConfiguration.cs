using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces;
using GymManagment.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.WebApi.Configuration.LayerConfiguration
{
    public static class DataAccessConfiguration
    {
        public static void ConfigureDataAccess(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString")!;
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
