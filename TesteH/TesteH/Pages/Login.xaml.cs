namespace TesteH.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void OnButtonLoginClicked(object sender, EventArgs e)
    {   //PushModalAsync tira bot�o de voltar para p�gina login 
        await Navigation.PushModalAsync(new MainPage());
	}
}