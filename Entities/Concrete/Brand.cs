using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
