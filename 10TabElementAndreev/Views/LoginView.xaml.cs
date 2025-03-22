using TabElementAndreev.ViewModels;

namespace TabElementAndreev.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}