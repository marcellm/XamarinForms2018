using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploAudio
{
    public partial class MainPage : ContentPage
    {
        ISimpleAudioPlayer player;

        public MainPage()
        {
            InitializeComponent();

            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

            //:::::::::::::::::::::::::::::::::::
            // ::::::::::: INSTRUÇÕES :::::::::::
            //:::::::::::::::::::::::::::::::::::
            // https://blog.xamarin.com/adding-sound-xamarin-forms-app
            // Baixar Plugin: Xam.Plugin.SimpleAudioPlayer
            // Colocar arquivo MP3 na pasta Assets do Android com BuildAction = AndroidAsset
            // Dar Play() no áudio como função abaixo
        }

        private void tocarSomPolicia(object sender, EventArgs args)
        {
            tocarSom("police.mp3");
        }

        private void tocarSomCachorro(object sender, EventArgs args)
        {
            tocarSom("dog.mp3");
        }

        private async void tocarSom(string filename)
        {
            try
            {
                //var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;

                try
                {
                    if (player.IsPlaying)
                    {
                        player.Stop();
                    }
                    else
                    {
                        player.Load(filename);

                        player.Play();
                    }
                }
                catch (Exception ex)
                {
                    player.Stop();

                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", ex.Message, "OK");
            }
        }

    }
}