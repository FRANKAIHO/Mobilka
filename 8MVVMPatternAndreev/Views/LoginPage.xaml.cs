using MVVMPatternAndreev.ViewsModels;

namespace MVVMPatternAndreev.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}