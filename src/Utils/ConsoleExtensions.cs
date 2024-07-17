using CliFx.Infrastructure;

namespace Tap.NetCore.CLI.Utils;

internal static class ConsoleExtensions
{
    public static void ExceptionDetails(this ConsoleWriter writer, Exception exception)
    {
        writer.Write("Exception: ");

        using (writer.Console.WithForegroundColor(ConsoleColor.White))
            writer.WriteLine(exception.Message);
    }

    public static void ExceptionDetails(this IConsole console, Exception exception) =>
        console.Output.ExceptionDetails(exception);
}