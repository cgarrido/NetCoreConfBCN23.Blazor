using Bunit;

namespace NetCoreConfBCN23.Shared.Tests
{
    public class CounterTests
    {
        [Fact]
        public void IncrementCount_increments_the_counter()
        {
            // Arrange
            var counter = new Counter();

            // Act
            counter.IncrementCount();

            // Asset
            Assert.Equal(1, counter.currentCount);
        }

        [Fact]
        public void Counter_is_incremented_when_the_button_is_clicked()
        {
            using var ctx = new TestContext();

            // Arrange
            var cut = ctx.RenderComponent<Counter>();

            // Act
            cut.Find("button").Click();

            // Assert
            Assert.Equal("Current count: 1", cut.Find("p").TextContent);
        }
    }
}