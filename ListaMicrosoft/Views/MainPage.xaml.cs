using ListaMicrosoft.Model;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListaMicrosoft
{
    using ListaMicrosoft.ViewModel;
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}