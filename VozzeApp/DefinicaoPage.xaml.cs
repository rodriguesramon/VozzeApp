using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace VozzeApp
{
    public partial class DefinicaoPage : ContentPage
    {
        public DefinicaoPage()
        {
            InitializeComponent();

        }

        void DefineFN(object sender, System.EventArgs e)
        {
            App.ContentFileConfig = "{'sexo' : 'F', 'cor' : 'N'}";
            File.WriteAllText(App.arquivoConfig, App.ContentFileConfig);
            //Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();

        }

        void DefineFB(object sender, System.EventArgs e)
        {
            App.ContentFileConfig = "{'sexo' : 'F', 'cor' : 'B'}";
            File.WriteAllText(App.arquivoConfig, App.ContentFileConfig);
            //Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();
        }

        void DefineMB(object sender, System.EventArgs e)
        {
            App.ContentFileConfig = "{'sexo' : 'M', 'cor' : 'B'}";
            File.WriteAllText(App.arquivoConfig, App.ContentFileConfig);
            //Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();
        }

        void DefineMN(object sender, System.EventArgs e)
        {
            App.ContentFileConfig = "{'sexo' : 'M', 'cor' : 'N'}";
            File.WriteAllText(App.arquivoConfig, App.ContentFileConfig);
            //Navigation.PushAsync(new MainPage());
            Navigation.PopAsync();
        }
    }
}
