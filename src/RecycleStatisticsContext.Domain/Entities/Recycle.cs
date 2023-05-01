using RecycleStatisticsContext.Domain.Common;

namespace RecycleStatisticsContext.Domain.Entities
{
    public class Recycle : EntityBase
    {
        public TypeRecycle TypeRecycle { get; private set; }
        public Guid TypeRecycleId { get; private set; }
        public int Count { get; private set; }

        public Recycle(Guid typeRecycleId, int count)
        {
            TypeRecycleId = typeRecycleId;
            Count = count;
        }
    }
}