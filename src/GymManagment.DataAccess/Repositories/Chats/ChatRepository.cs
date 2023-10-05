using GymManagment.DataAccess.DbContexts;
using GymManagment.DataAccess.Intarfaces.Chats;
using GymManagment.Domain.Entities.Chats;

namespace GymManagment.DataAccess.Repositories.Chats;

public class ChatRepository : GenericRepository<Chat>, IChatRepositopy
{
    public ChatRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
