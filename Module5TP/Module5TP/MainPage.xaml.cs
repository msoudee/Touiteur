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
        public MainPage()
        {
            InitializeComponent();
        }

        public void ConnectionClicked(object sender, EventArgs e)
        {
            string id = this.identifiant.Text;
            string mdp = this.motDePasse.Text;
            bool memo = this.memoriserInfos.IsToggled;

            if(checkString(id) && checkString(mdp))
            {
                if(mdp.Length >= 6)
                {
                    this.errorMessage.IsVisible = false;
                    this.formulaire.IsVisible = false;
                    this.listeTweet.IsVisible = true;
                }
                else
                {
                    this.errorMessage.IsVisible = true;
                }
            }
            else
            {
                this.errorMessage.IsVisible = true;
            }
        }

        private bool checkString(string str)
        {
            return str != null && str.Length >= 3;
        }
    }
}
