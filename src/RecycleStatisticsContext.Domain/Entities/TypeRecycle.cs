using RecycleStatisticsContext.Domain.Common;

namespace RecycleStatisticsContext.Domain.Entities
{
    public class TypeRecycle : EntityBase
    {
        public string? Name { get; set; }
        public Guid Id { get; set; }

        public TypeRecycle() { }

        public TypeRecycle(string? name, Guid id)
        {
            Name = name;
            Id = id;
        }
    }
}
