
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnrollmentPage : ContentPage
    {
        public EnrollmentPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}