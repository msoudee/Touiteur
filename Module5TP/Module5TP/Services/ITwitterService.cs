using Module5TP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module5TP.Services
{
    public interface ITwitterService
    {
        bool authenticate(string user, string password);

        List<Tweet> getTweets(string str);
    }
}
