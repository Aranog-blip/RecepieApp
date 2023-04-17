namespace RecepieApp;

public partial class RecepieBookPage : ContentPage
{

	public RecepieBookPage()
	{
		InitializeComponent();
		recepieList.ItemsSource = App.RecepieBookHistory.GetAll();
	}
}