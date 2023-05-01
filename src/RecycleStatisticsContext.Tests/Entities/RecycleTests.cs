using Xunit;

namespace RecycleStatisticsContext.Tests.Entities
{
    public class RecycleTests
    {
        [Fact]
        public void Empty()
        {
        }

        [Fact]
        public void CreateRecycle()
        {
            var recycle = new Recycle("Oil kitchen", 1);

            Assert.Equal("Oil kitchen", recycle.TypeRecycle);
            Assert.Equal(1, recycle.Count);
        }
    }

    public class Recycle
    {
        public string TypeRecycle { get; set; }
        public int Count { get; set; }

        public Recycle(string typeRecycle, int count)
        {
            TypeRecycle = typeRecycle;
            Count = count;
        }
    }
}

