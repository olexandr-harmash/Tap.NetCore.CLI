namespace Tap.NetCore.CLI.Tests;

public class HealthCheckCommandUnitTest1
{
    // Arrange
    private FakeInMemoryConsole _console;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _console = new FakeInMemoryConsole();
    }

    [Test]
    public async Task HealthCheckCommand_executes_successfully()
    {
        var command = new HealthCheckCommand
        {
            Details = "SOMETHING WRONG!!!"
        };

        // Act
        await command.ExecuteAsync(_console);

        // Assert
        var stdOut = _console.ReadOutputString();
        Assert.That(stdOut, Is.EqualTo("Exception: SOMETHING WRONG!!!\r\n"));
    }
}