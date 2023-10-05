using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces;
using GymManagment.DataAccess.Intarfaces.Admins;
using GymManagment.DataAccess.Intarfaces.Chats;
using GymManagment.DataAccess.Intarfaces.Orders;
using GymManagment.DataAccess.Intarfaces.Products;
using GymManagment.DataAccess.Intarfaces.Users;
using GymManagment.DataAccess.Repositories.Admins;
using GymManagment.DataAccess.Repositories.Chats;
using GymManagment.DataAccess.Repositories.Orders;
using GymManagment.DataAccess.Repositories.Products;
using GymManagment.DataAccess.Repositories.Users;

namespace GymManagment.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private AppDbContext _appDbContext;

    public IAdminRepository Admin { get; }
    public IUserRepository User { get; }
    public IProductRepository Product { get; }
    public IOrderRepository Order { get; }
    public IChatRepositopy Chat { get; }

    public UnitOfWork(AppDbContext appDbContext)
    {
        this._appDbContext = appDbContext;

        this.Admin = new AdminRepository(appDbContext); 
        this.User = new UserRepository(appDbContext);
        this.Product = new ProductRepository(appDbContext);
        this.Order = new OrderRepository(appDbContext);
        this.Chat = new ChatRepository(appDbContext);

    }
    public async Task<int> SaveChangesAsync()
        => await _appDbContext.SaveChangesAsync();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

}
