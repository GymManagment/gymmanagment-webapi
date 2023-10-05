using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces.Orders;
using GymManagment.Domain.Entities.Orders;

namespace GymManagment.DataAccess.Repositories.Orders;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
