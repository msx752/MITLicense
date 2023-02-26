namespace PackZero.HostedConsoleService;

public static class HostedServiceExtensions
{
    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, Action<IServiceCollection> actionServices, CancellationToken cancellationToken = default)
        where T : class, IHostedService

    {
        RunAppZeroConsoleAsync<T>(hostBuilder, configureOptions, actionServices, cancellationToken).ConfigureAwait(false).GetAwaiter().GetResult();
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, Action<IServiceCollection> actionServices)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(configureOptions, actionServices, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(configureOptions, null, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(null, null, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, Action<IServiceCollection> actionServices, CancellationToken cancellationToken)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(null, actionServices, cancellationToken);
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, Action<IServiceCollection> actionServices)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(null, actionServices, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static void RunAppZeroConsole<T>(this IHostBuilder hostBuilder, CancellationToken cancellationToken)
        where T : class, IHostedService
    {
        hostBuilder.RunAppZeroConsole<T>(null, null, cancellationToken);
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, Action<IServiceCollection> actionServices, CancellationToken cancellationToken = default)
        where T : class, IHostedService

    {
        hostBuilder.ConfigureServices((services) =>
        {
            services.AddHostedService<T>();
            actionServices?.Invoke(services);
        });
        if (configureOptions != null)
            return hostBuilder.RunConsoleAsync(configureOptions, cancellationToken);
        else
            return hostBuilder.RunConsoleAsync(cancellationToken);
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions, Action<IServiceCollection> actionServices)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(configureOptions, actionServices, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, Action<ConsoleLifetimeOptions> configureOptions)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(configureOptions, null, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(null, null, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, Action<IServiceCollection> actionServices, CancellationToken cancellationToken)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(null, actionServices, cancellationToken);
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, Action<IServiceCollection> actionServices)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(null, actionServices, new CancellationToken());
    }

    [UnsupportedOSPlatform("android")]
    [UnsupportedOSPlatform("browser")]
    [UnsupportedOSPlatform("ios")]
    [UnsupportedOSPlatform("tvos")]
    public static Task RunAppZeroConsoleAsync<T>(this IHostBuilder hostBuilder, CancellationToken cancellationToken)
        where T : class, IHostedService
    {
        return hostBuilder.RunAppZeroConsoleAsync<T>(null, null, cancellationToken);
    }
}