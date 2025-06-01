using DIWpfExample;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

public partial class App : Application
{
    public static ServiceProvider ServiceProvider { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();

        // Services und ViewModels registrieren
        services.AddSingleton<IGreetingService, GreetingService>();
        services.AddTransient<MainViewModel>();

        ServiceProvider = services.BuildServiceProvider();

        var mainWindow = new MainWindow
        {
            DataContext = ServiceProvider.GetRequiredService<MainViewModel>()
        };

        mainWindow.Show();
        base.OnStartup(e);
    }
}
