using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces.Users;
using GymManagment.Domain.Entities.Users;

namespace GymManagment.DataAccess.Repositories.Users;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
