using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces.Admins;
using GymManagment.Domain.Entities.Admins;
using System.Linq.Expressions;

namespace GymManagment.DataAccess.Repositories.Admins;

public class AdminRepository : GenericRepository<Admin>, IAdminRepository
{
    public AdminRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
