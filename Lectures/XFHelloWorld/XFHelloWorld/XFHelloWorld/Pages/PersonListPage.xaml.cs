﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFHelloWorld.Model;
using XFHelloWorld.ViewModels;

namespace XFHelloWorld.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage(People people)
        {
            this.BindingContext = new PersonListViewModel(this.Navigation, people.Persons);
            InitializeComponent();

            if (Device.RuntimePlatform == Device.UWP)
            {
                this.ListView.BackgroundColor = Color.Aqua;
            }
        }
    }
}