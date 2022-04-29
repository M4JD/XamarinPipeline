using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test_mobile_app.Models;
using Test_mobile_app.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_mobile_app.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}