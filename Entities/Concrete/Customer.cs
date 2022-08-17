using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
    }
}
