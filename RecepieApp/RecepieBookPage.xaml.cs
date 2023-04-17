namespace RecepieApp;

public partial class RecepieBookPage : ContentPage
{
	public string RecepieBook { get; set; }
	public RecepieBookPage(string recepieBook)
	{
		InitializeComponent();
		RecepieBook = recepieBook;
		recepieList.ItemsSource = App.RecepieBookHistory.GetAll();
	}
}