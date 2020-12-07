
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UniversityApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DepartmentPage : ContentPage
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}