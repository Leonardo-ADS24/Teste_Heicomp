namespace TesteH.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void OnButtonLoginClicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new AppShell();
	}
}