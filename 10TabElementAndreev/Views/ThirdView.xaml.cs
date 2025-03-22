using TabElementAndreev.ViewModels;

namespace TabElementAndreev.Views;

public partial class ThirdView : ContentPage
{
	public ThirdView()
	{
		InitializeComponent();
        BindingContext = new ThirdViewModel();
    }
}