using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace VozzeApp
{
    public partial class MainPage : ContentPage
    {
        public void executeAudio(string file){
            var player = CrossSimpleAudioPlayer.Current;
            player.Load(file);
            player.Play();
        }

        async void btnFeliz_Clicked(object sender, System.EventArgs e)
        {
            var file =  App.Sexo + "_Feliz.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnFeliz.RotateTo(360, 1000),
                btnFeliz.ScaleTo(2, 800)
            );
            await btnFeliz.ScaleTo(1, 400);


        }

        async void btnFome_Clicked(object sender, System.EventArgs e)
        {
            var file = App.Sexo + "_Fome.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnFome.RotateTo(360, 1000),
                btnFome.ScaleTo(2, 800)
            );
            await btnFome.ScaleTo(1, 400);
        }

        async void btnChorando_Clicked(object sender, System.EventArgs e)
        {
            var file = App.Sexo + "_Triste.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnChorando.RotateTo(360, 1000),
                btnChorando.ScaleTo(2, 800)
            );
            await btnChorando.ScaleTo(1, 400);
        }

        async void btnBanheiro_Clicked(object sender, System.EventArgs e)
        {
            var file = App.Sexo + "_Banheiro.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnBanheiro.RotateTo(360, 1000),
                btnBanheiro.ScaleTo(2, 800)
            );
            await btnBanheiro.ScaleTo(1, 400);
        }

        async void btnRaiva_Clicked(object sender, System.EventArgs e)
        {
            var file = App.Sexo + "_Raiva.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnRaiva.RotateTo(360, 1000),
                btnRaiva.ScaleTo(2, 800)
            );
            await btnRaiva.ScaleTo(1, 400);
        }

        async void btnSono_Clicked(object sender, System.EventArgs e)
        {
            var file = App.Sexo + "_Sono.mp3";
            executeAudio(file);

            await Task.WhenAny<bool>
            (
                btnSono.RotateTo(360, 1000),
                btnSono.ScaleTo(2, 800)
            );
            await btnSono.ScaleTo(1, 400);
        }

        void btnSim_Clicked(object sender, System.EventArgs e)
        {
            var file = "S_" + App.Sexo + ".mp3";
            executeAudio(file);
        }

        void btnNao_Clicked(object sender, System.EventArgs e)
        {
            var file = "N_" + App.Sexo + ".mp3";
            executeAudio(file);
        }

        public void GetConfig()
        {
            var json = File.ReadAllText(App.arquivoConfig);
            var dados = JsonConvert.DeserializeObject<Definicao>(json);

            App.Sexo = dados.Sexo;
            App.Cor = dados.Cor;
        }

        public void CheckFile()
        {
            if (File.Exists(App.arquivoConfig)){
            }else{
                App.ContentFileConfig = "{'sexo' : 'F', 'cor' : 'N'}";
                File.WriteAllText(App.arquivoConfig, App.ContentFileConfig);
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CheckFile();
            GetConfig();
            DefinePersona();
        }

        void DefinePersona()
        {
            var prefix = App.Sexo + App.Cor + "_";

            btnFeliz.Image = prefix + "FELIZ.png";
            btnFome.Image = prefix + "FOME.png";
            btnChorando.Image = prefix + "CHORANDO.png";
            btnBanheiro.Image = prefix + "BANHEIRO.png";
            btnRaiva.Image = prefix + "RAIVA.png";
            btnSono.Image = prefix + "SONO.png";

            btnFeliz.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);
            btnFome.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);
            btnChorando.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);
            btnBanheiro.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);
            btnRaiva.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);
            btnSono.BackgroundColor = Color.FromHsla(255, 100, 60, 0.4);

        }
    }       
}
