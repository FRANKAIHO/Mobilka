using TabElementAndreev.ViewModels;

namespace TabElementAndreev.Views;

public partial class SecondView : ContentPage
{
	public SecondView()
	{
		InitializeComponent();
		BindingContext = new SecondViewModel();
	}
}