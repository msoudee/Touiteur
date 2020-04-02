using Module5TP.Services;
using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Module5TP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private TwitterService twitterService;

        public MainPage()
        {
            InitializeComponent();

            twitterService = new TwitterService();
        }

        public void ConnectionClicked(object sender, EventArgs e)
        {
            string id = this.identifiant.Text;
            string mdp = this.motDePasse.Text;
            bool memo = this.memoriserInfos.IsToggled;

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if (id != null && id.Length > 3 && mdp != null && mdp.Length > 6)
                {
                    if (twitterService.authenticate(id, mdp))
                    {
                        this.afficherPageSuivante();
                    }
                    else
                    {
                        this.errorMessage.Text = "L'identifiant ou le mot de passe est incorrect";
                        this.errorMessage.IsVisible = true;
                    }
                }
                else
                {
                    this.errorMessage.Text = "L'identifiant doit faire plus de 3 caractères et le mot de passe doit faire plus de 6 carctères";
                    this.errorMessage.IsVisible = true;
                }
            }
            else
            {
                this.errorMessage.Text = "Vous n'êtes pas connecté à internet";
                this.errorMessage.IsVisible = true;
            }
        }

        async void afficherPageSuivante()
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}