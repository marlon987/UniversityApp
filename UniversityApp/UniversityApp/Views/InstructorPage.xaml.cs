
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructorPage : ContentPage
    {
        public InstructorPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}