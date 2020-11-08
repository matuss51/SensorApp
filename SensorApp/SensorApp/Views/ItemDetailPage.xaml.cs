using System.ComponentModel;
using Xamarin.Forms;
using SensorApp.ViewModels;

namespace SensorApp.Views
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