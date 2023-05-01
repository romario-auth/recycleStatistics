using RecycleStatisticsContext.Domain.Common;

namespace RecycleStatisticsContext.Domain.Entities
{
    public class TypeRecycle : EntityBase
    {
        public string? Type { get; set; }
        public Guid Id { get; set; }

        public TypeRecycle() { }

        public TypeRecycle(string? type, Guid id)
        {
            Type = type;
            Id = id;
        }
    }
}
