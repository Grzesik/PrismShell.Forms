using Microsoft.Extensions.DependencyInjection;

namespace ShellWithPrismForms.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new ShellWithPrismForms.App(AddServices));
        }

        static void AddServices(IServiceCollection services)
        {
            //services.AddSingleton<IAppInfoService, AppInfoService>();
        }
    }
}
