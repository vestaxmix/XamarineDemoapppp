﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        void loginButton_Clicked(object sender,  EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        void loginButton_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
