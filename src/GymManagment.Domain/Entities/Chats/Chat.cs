namespace GymManagment.Domain.Entities.Chats;

public class Chat:Auditable
{
    public long UserId { get; set; }
    public bool ChatText { get; set; }
}