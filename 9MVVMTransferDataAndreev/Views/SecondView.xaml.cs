using MVVMTransferDataAndreev.ViewModels;

namespace MVVMTransferDataAndreev.Views;

public partial class SecondView : ContentPage
{
	public SecondView()
	{
		InitializeComponent();
		BindingContext = new SecondViewModel();
	}
}