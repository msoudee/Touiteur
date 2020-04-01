using Module5TP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (id != null && id.Length > 3 && mdp != null && mdp.Length > 6)
            {
                if (twitterService.authenticate(id, mdp))
                {
                    this.errorMessage.IsVisible = false;
                    this.formulaire.IsVisible = false;
                    this.listeTweet.IsVisible = true;
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
    }
}