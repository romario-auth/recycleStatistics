using ExpectedObjects;
using System.Security.Cryptography;
using Xunit;

namespace RecycleStatisticsContext.Tests.Entities
{
    public class RecycleTests
    {
        private readonly Recycle _recycle;

        public RecycleTests()
        {
            var typeRecycle = new TypeRecycle("Oil kitchen", Guid.NewGuid());
            _recycle = new Recycle(typeRecycle.Id, 1);
        }

        [Fact]
        public void Empty()
        {
        }

        [Fact]
        public void CreateFirstRecycle()
        {
            Assert.Equal(_recycle.TypeRecycle, _recycle.TypeRecycle);
            Assert.Equal(1, _recycle.Count);
        }

        [Fact]
        public void CreateRecycleWithType_Plastic()
        {
            TypeRecycle typeRecycle = new TypeRecycle("Plastic", Guid.NewGuid());

            var recycle = new
            {
                TypeRecycleId = typeRecycle.Id,
                Count = 1
            }.ToExpectedObject();

            var recycleActual = new Recycle(typeRecycle.Id, 1);

            recycle.ShouldMatch(recycleActual);
        }
    }

    public class TypeRecycle
    {
        public string? Type { get; set; }
        public Guid Id { get; set; }

        public TypeRecycle() {}

        public TypeRecycle(string? type, Guid id)
        {
            Type = type;
            Id = id;
        }
    }

    public class Recycle
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

