using FrameOtpCircleAnim.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FrameOtpCircleAnim.Views
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