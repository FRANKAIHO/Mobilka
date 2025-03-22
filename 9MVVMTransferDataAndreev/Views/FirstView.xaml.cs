using MVVMTransferDataAndreev.ViewModels;

namespace MVVMTransferDataAndreev.Views;

public partial class FirstView : ContentPage
{
	public FirstView()
	{
		InitializeComponent();
		BindingContext = new FirstViewModel();
	}

	private void GoToSecondPage(object sender, EventArgs e) 
	{
		AppShell.Current.GoToAsync(nameof(SecondView), true);
	}
}