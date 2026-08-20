namespace VanderPet.Views;

public partial class frmPet : ContentPage
{
    App PropriedadeApp;
	public frmPet()
	{
		InitializeComponent();
        PropriedadeApp = (App)Application.Current;
        pckEspecies.ItemsSource = PropriedadeApp.lstEspecies;
        pckRacas.ItemsSource = PropriedadeApp.lstRacas;
        pckServicos.ItemsSource = PropriedadeApp.lstServicos;
        dtPckServico.MinimumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+1);
        dtPckServico.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Sucesso", "PET Cadastrado com sucesso!", "OK");
        await Navigation.PopAsync();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}