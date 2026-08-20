namespace VanderPet.Views;

public partial class frmLogin : ContentPage
{
	public frmLogin()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
        {
            await DisplayAlertAsync("Erro", "Preencha todos os campos!", "OK");
            return;
        }
        if(txtUsuario.Text == "admin" && txtSenha.Text == "admin")
        {
            await DisplayAlertAsync("Sucesso", "Login realizado com sucesso!", "OK");
            await Navigation.PushAsync(new frmPet());
        }
        else
        {
            await DisplayAlertAsync("Erro", "Usuário ou senha incorretos!", "OK");
        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new frmCadastro());
    }
}