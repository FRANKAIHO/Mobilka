using TabElementAndreev.ViewModels;

namespace TabElementAndreev.Views;

public partial class FirstView : ContentPage
{
	public FirstView()
	{
		InitializeComponent();
		BindingContext = new FirstViewModel();
	}
}