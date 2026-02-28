using Xunit;
using SampleApp;

namespace SampleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void GetMessage_ReturnsHelloWorld()
    {
        // Arrange & Act
        var result = Program.GetMessage();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
}
