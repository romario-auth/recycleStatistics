using ExpectedObjects;
using Xunit;
using RecycleStatisticsContext.Domain.Entities;

namespace RecycleStatisticsContext.Tests.Entities
{
    public class TypeRecycleTests
    {
        private readonly TypeRecycle _typeRecycle;

        public TypeRecycleTests()
        {
            _typeRecycle = new TypeRecycle("Oil kitchen");
        }

        [Fact]
        public void Empty(){}

        [Fact]
        public void CreateFirstTypeRecycle()
        {
            Guid typeRecycleId = Guid.NewGuid();

            var typeRecycleExpected = new
            {
                Name = "Oil kitchen"
            }.ToExpectedObject();

            typeRecycleExpected.ShouldMatch(_typeRecycle);
        }
    }
}
