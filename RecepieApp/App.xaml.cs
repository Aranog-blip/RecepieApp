using RecepieApp.Data;

namespace RecepieApp;

public partial class App : Application
{
	public static RecepieBookHistory RecepieBookHistory { get; private set; }	
		
		public App(RecepieBookHistory recepieBookHistory)
	{
		InitializeComponent();

		MainPage = new AppShell();
		
		RecepieBookHistory = recepieBookHistory;
	}
}
