using GymManagment.DataAccess.Intarfaces.Admins;
using GymManagment.DataAccess.Intarfaces.Chats;
using GymManagment.DataAccess.Intarfaces.Orders;
using GymManagment.DataAccess.Intarfaces.Products;
using GymManagment.DataAccess.Intarfaces.Users;

namespace GymManagment.DataAccess.Intarfaces;

public interface IUnitOfWork
{
    public IAdminRepository Admin { get; }
    public IUserRepository User { get; }
    public IProductRepository Product { get; }
    public IOrderRepository Order { get; }
    public IChatRepositopy Chat { get; }

    public Task<int> SaveChangesAsync();
}
