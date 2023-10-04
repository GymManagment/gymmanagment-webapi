namespace GymManagment.Domain.Entities.Orders;

public class Order:Auditable
{
    public long UserId { get; set; }
    public long ProductId { get; set; }
    public bool status { get; set; }

}
