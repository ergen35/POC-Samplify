namespace Samplify.Views;

public partial class MonkeyDetailsPage : ContentPage
{
	public MonkeyDetailsPage(MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}