using Samplify.Views;

namespace Samplify
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MonkeyDetailsPage), typeof(MonkeyDetailsPage));
        }
    }
}
