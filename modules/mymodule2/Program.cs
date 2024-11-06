using mymodule2;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>services.AddHostedService<ModuleBackgroundService>())
    .Build();

host.Run();