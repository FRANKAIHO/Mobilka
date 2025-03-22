using MVVMPatternAndreev.ViewsModels;

namespace MVVMPatternAndreev.Views;

public partial class RegPage : ContentPage
{
	public RegPage()
	{
		InitializeComponent();
		BindingContext = new RegViewModel();
	}
}