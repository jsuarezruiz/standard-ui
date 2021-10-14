using System.ComponentModel;
using Xamarin.Forms;
using XamarinFormsSamplesHost.ViewModels;

namespace XamarinFormsSamplesHost.Views
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