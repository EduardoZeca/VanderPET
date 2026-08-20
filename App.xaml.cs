using Microsoft.Extensions.DependencyInjection;
using VanderPet.Models;

namespace VanderPet
{
    public partial class App : Application
    {
        public List<Especies> lstEspecies = new List<Especies>
        {
            new Especies() { Id = 1, Especie = "Mamifero" },
            new Especies() { Id = 2, Especie = "Ave" },
            new Especies() { Id = 3, Especie = "Réptil" }
        };
        public List<Racas> lstRacas = new List<Racas>
        {
            new Racas() { Id = 1, Raca = "Cachorro", EspecieId = 1 },
            new Racas() { Id = 2, Raca = "Gato", EspecieId = 1 },
            new Racas() { Id = 3, Raca = "Papagaio", EspecieId = 2 },
            new Racas() { Id = 4, Raca = "Canário", EspecieId = 2 },
            new Racas() { Id = 5, Raca = "Cobra", EspecieId = 3 },
            new Racas() { Id = 6, Raca = "Tartaruga", EspecieId = 3 }
        };
        public List<Servicos> lstServicos = new List<Servicos>
        {
            new Servicos() { Id = 1, Servico = "Banho (Porte Pequeno)", Preco = 50.00m, Tempo = 30 },
            new Servicos() { Id = 2, Servico = "Banho (Porte Médio)", Preco = 70.00m, Tempo = 45 },
            new Servicos() { Id = 3, Servico = "Banho (Porte Grande)", Preco = 90.00m, Tempo = 60 }
        };

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.frmPrincipal());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 375;
            window.Height = 812;
            return window;
        }
    }
}