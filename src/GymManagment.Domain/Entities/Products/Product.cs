using GymManagment.Domain.Enums;

namespace GymManagment.Domain.Entities.Products;

public class Product:Auditable
{
    public long UserId { get; set; }
    public string Name { get; set; }=string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public double Price { get; set; }
    public string Image { get; set; }= string.Empty;
    public int Quantity { get; set; }
    public string Description { get; set; } = string.Empty;
    public ProductRole Role { get; set; }

}
