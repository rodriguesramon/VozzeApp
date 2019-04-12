using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VozzeApp
{
    public partial class App : Application
    {
        public static string AppDiretorio { get; set; }
        public static string arquivoConfig { get; set; }
        public static string Cor { get; set; }
        public static string Sexo { get; set; }
        public static string ContentFileConfig { get; set; }

        public App()
        {
            InitializeComponent();

            AppDiretorio = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData)
            );

            arquivoConfig = Path.Combine(AppDiretorio, "config.json");

            MainPage = new Menu();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
