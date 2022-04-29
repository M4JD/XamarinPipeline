using System.ComponentModel;
using Test_mobile_app.ViewModels;
using Xamarin.Forms;

namespace Test_mobile_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}