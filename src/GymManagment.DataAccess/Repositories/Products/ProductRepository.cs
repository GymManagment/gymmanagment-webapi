using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces.Products;
using GymManagment.Domain.Entities.Products;

namespace GymManagment.DataAccess.Repositories.Products;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
