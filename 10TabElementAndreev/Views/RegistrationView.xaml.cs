using TabElementAndreev.ViewModels;

namespace TabElementAndreev.Views;

public partial class RegistrationView : ContentPage
{
	public RegistrationView()
	{
		InitializeComponent();
		BindingContext = new RegistrationViewModel();
	}
}