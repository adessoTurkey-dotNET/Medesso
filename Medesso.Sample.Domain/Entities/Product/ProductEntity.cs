using Medesso.Sample.Domain.Entities.Base;

namespace Medesso.Sample.Domain.Entities.Product;

public partial class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}