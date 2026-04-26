using Microsoft.Extensions.DependencyInjection;

namespace MeuPostinho
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Agendamento());
        }

       
    }
}