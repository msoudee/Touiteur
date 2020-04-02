using Module5TP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Module5TP.Services
{
    public interface ITwitterService
    {
        bool authenticate(string user, string password);

        ObservableCollection<Tweet> getTweets(string str);
    }
}
