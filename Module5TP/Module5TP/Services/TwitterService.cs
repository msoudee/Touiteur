using Module5TP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module5TP.Services
{
    public class TwitterService : ITwitterService
    {
        private string CORRECT_USER = "msoudee";
        private string CORRECT_PSWD = "password";

        public bool authenticate(string user, string password)
        {
            return CORRECT_USER.Equals(user) && CORRECT_PSWD.Equals(password);
        }

        public ObservableCollection<Tweet> getTweets(string str)
        {
            ObservableCollection<Tweet> tweets = new ObservableCollection<Tweet>();

            tweets.Add(new Tweet { Identifiant = "1", DateCreation = "01/04/20 12:29", IdentifiantUtilisateur = "1", NomUtilisateur = "Maxence", PseudoUtilisateur = "@msoudee", Texte = "Il s'agit d'un test"});
            tweets.Add(new Tweet { Identifiant = "2", DateCreation = "01/04/20 12:34", IdentifiantUtilisateur = "1", NomUtilisateur = "Maxence", PseudoUtilisateur = "@msoudee", Texte = "Et mais c'est qu'il est l'heure d'aller manger !!"});
            tweets.Add(new Tweet { Identifiant = "3", DateCreation = "01/04/20 13:34", IdentifiantUtilisateur = "1", NomUtilisateur = "Maxence", PseudoUtilisateur = "@msoudee", Texte = "Repas en 1h pile ! C'était trop bon !"});

            return tweets;
        }
    }
}
