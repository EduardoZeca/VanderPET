namespace VanderPet.Views;

public partial class frmPrincipal : ContentPage
{
	public frmPrincipal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new frmLogin());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new frmPet());
    }
}