using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using UniversityApp.BL.DTOs;
using UniversityApp.BL.Services.Implements;
using UniversityApp.Helpers;
using Xamarin.Forms;

namespace UniversityApp.ViewModels
{
    public class EnrollmentsViewModel : BaseViewModel
    {

        private BL.Services.IEnrollmentService enrollmentService;
        private ObservableCollection<EnrollmentDTO> enrollment;
        private bool isRefreshing;

        public ObservableCollection<EnrollmentDTO> Enrollment
        {
            get { return this.enrollment; }
            set { this.SetValue(ref this.enrollment, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { this.SetValue(ref this.isRefreshing, value); }
        }

        public EnrollmentsViewModel()
        {
            this.enrollmentService = new EnrollmentService();
            this.RefreshCommand = new Command(async () => await GetEnrollments());
            this.RefreshCommand.Execute(null);
        }

        public Command RefreshCommand { get; set; }

        async Task GetEnrollments()
        {
            try
            {
                this.IsRefreshing = true;

                var connection = await enrollmentService.CheckConnection();
                if (!connection)
                {
                    this.IsRefreshing = false;
                    await Application.Current.MainPage.DisplayAlert("Error", "No internet connection", "Cancel");
                    return;
                }

                var listEnrollments = await enrollmentService.GetAll(EndPoints.GET_ENROLLMENTS);
                this.Enrollment = new ObservableCollection<EnrollmentDTO>(listEnrollments);
                this.IsRefreshing = false;
            }
            catch (Exception ex)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Cancel");
            }

        }
    }
}

