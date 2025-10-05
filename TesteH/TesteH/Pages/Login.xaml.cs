namespace TesteH.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void onButtonLoginClicked(object sender, EventArgs e)
    {   //PushModalAsync tira botão de voltar para página login 
        await Navigation.PushModalAsync(new MainPage());
	}
}