﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module5TP.Models
{
    public class Tweet
    {
        public string Identifiant { get; set; }

        public string DateCreation { get; set; }

        public string Texte { get; set; }

        public string NomUtilisateur { get; set; }

        public string IdentifiantUtilisateur { get; set; }

        public string PseudoUtilisateur { get; set; }
    }
}
