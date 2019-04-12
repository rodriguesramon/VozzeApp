using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VozzeApp
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            Detail = new NavigationPage(new MainPage());
        }

        void DefineConfigs(object sender, System.EventArgs e)
        {
            //string nome = Path.GetFileName("config") + ".json";
            //string nomeArquivo = Path.Combine(App.AppDiretorio, $"{nome}");

            //string conteudoTexto = "{'sexo':'m', 'cor':'moreno'}";

            //File.WriteAllText(nomeArquivo, conteudoTexto);

            Detail.Navigation.PushAsync(new Test());
            IsPresented = false;
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new DefinicaoPage());
            IsPresented = false;
        }
    }
}
