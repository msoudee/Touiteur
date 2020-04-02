﻿using Module5TP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Module5TP
{
    [DesignTimeVisible(false)]
    public partial class SecondPage : ContentPage
    {
        private TwitterService twitterService;

        public SecondPage()
        {
            InitializeComponent();

            twitterService = new TwitterService();

            this.maListeDeTweet.ItemsSource = twitterService.getTweets("");
        }
    }
}