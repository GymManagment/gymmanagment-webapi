using GymManagment.Domain.Entities.Admins;
using GymManagment.Domain.Entities.Chats;
using GymManagment.Domain.Entities.Orders;
using GymManagment.Domain.Entities.Products;
using GymManagment.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.DataAccess.DbContexts;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Chat> Chats { get; set; }
}
