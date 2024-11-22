using Xamarin.Forms;

namespace FormCV_xam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Establece la página principal (MainPage) como la página inicial
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
