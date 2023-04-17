using System.IO;

namespace RecepieApp;

public partial class MainPage : ContentPage
{
	
	

	public MainPage()
	{
		InitializeComponent();
	}
    private void OnClickSave (object sender, EventArgs e)
	{
		App.RecepieBookHistory.Add(new Models.Recepie
		{
			Name = InputName.Text,
			Link = InputLinkOf.Text,
			Description = InputDescriptionOf.Text,
			Type = InputTypeOf.Text,
		});

    }

	private void ToRecepiePagebnt (object sender, EventArgs e)
	{
		Button PageButton = (Button)sender;

		Navigation.PushAsync(new RecepieBookPage(PageButton.Text));
	}


}

