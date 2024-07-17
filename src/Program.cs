using CliFx;
using Microsoft.Extensions.DependencyInjection;

return await new CliApplicationBuilder()
    .SetDescription("Tap CLI application use Tap service features.")
    .AddCommandsFromThisAssembly()
    .UseTypeActivator(commandTypes =>
    {
        // We use Microsoft.Extensions.DependencyInjection for injecting dependencies in commands
        var services = new ServiceCollection();

        // Register all commands as transient services
        foreach (var commandType in commandTypes)
            services.AddTransient(commandType);

        return services.BuildServiceProvider();
    })
    .Build()
    .RunAsync();