
using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;

using Tap.NetCore.CLI.Utils;

namespace Tap.NetCore.CLI.Commands;

[Command("healthcheck", Description = "Throw exception and show something.")]
public class HealthCheckCommand() : ICommand
{
    [CommandParameter(0, Name = "title", Description = "Exception details text.")]
    public required string Details { get; init; }

    public ValueTask ExecuteAsync(IConsole console)
    {
        bool liveAbility = false;

        if (liveAbility is false)
            console.ExceptionDetails(new Exception(Details));
        
        return default;
    }
}