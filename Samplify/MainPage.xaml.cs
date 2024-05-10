namespace Samplify
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MonkeysViewModel viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }

}
