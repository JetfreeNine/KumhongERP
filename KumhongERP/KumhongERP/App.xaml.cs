using KumhongERP.Modules.ModuleName;
using KumhongERP.Services;
using KumhongERP.Services.Interfaces;
using KumhongERP.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace KumhongERP;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell()
    {
        return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IMessageService, MessageService>();
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<ModuleNameModule>();
    }
}
