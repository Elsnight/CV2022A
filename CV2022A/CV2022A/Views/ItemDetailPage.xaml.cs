using CV2022A.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CV2022A.Views
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