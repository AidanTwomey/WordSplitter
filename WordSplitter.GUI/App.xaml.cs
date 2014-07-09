using System.Windows;

namespace WordSplitter.GUI
{
    public partial class App : Application
    {
        private readonly GuiBootstrapper _bootstrapper = new GuiBootstrapper();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _bootstrapper.Run();
        }

    }
}
