﻿using System;
using System.Threading.Tasks;
using UniversityApp.BL.DTOs;
using UniversityApp.BL.Services.Implements;
using UniversityApp.Helpers;
using Xamarin.Forms;

namespace UniversityApp.ViewModels
{
    public class CreateInstructorViewModel : BaseViewModel
    {
        #region Properties
        private BL.Services.IInstructorService instructorService;
        private string lastName;
        private string firstMidName;
        private DateTime hireDate;
        private bool isEnabled;
        private bool isRunning;


        public string LastName
        {
            get { return this.lastName; }
            set { this.SetValue(ref this.lastName, value); }
        }

        public string FirstMidName
        {
            get { return this.firstMidName; }
            set { this.SetValue(ref this.firstMidName, value); }
        }

        public DateTime HireDate
        {
            get { return this.hireDate; }
            set { this.SetValue(ref this.hireDate, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { this.SetValue(ref this.isEnabled, value); }
        }
        public bool IsRunning
        {
            get { return this.isRunning; }
            set { this.SetValue(ref this.isRunning, value); }
        }
        #endregion

        public CreateInstructorViewModel()
        {
            this.instructorService = new InstructorService();
            this.SaveCommand = new Command(async () => await CreateInstructor());

            this.IsRunning = false;
            this.IsEnabled = true;
        }

        public Command SaveCommand { get; set; }

        async Task CreateInstructor()
        {
            try
            {
                if (string.IsNullOrEmpty(this.LastName))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You must enter the field title", "Cancel");
                    return;
                }

                this.IsRunning = true;
                this.IsEnabled = false;

                var connection = await instructorService.CheckConnection();
                if (!connection)
                {
                    this.IsRunning = false;
                    this.IsEnabled = true;

                    await Application.Current.MainPage.DisplayAlert("Error", "No internet connection", "Cancel");
                    return;
                }

                var instructorDTO = new InstructorDTO { LastName = this.LastName, FirstMidName = this.FirstMidName, HireDate = this.HireDate };
                await instructorService.Create(EndPoints.POST_INSTRUCTORS, instructorDTO);

                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert("Message", "The process is successful", "Cancel");


                this.LastName = this.FirstMidName = string.Empty;
                await Application.Current.MainPage.Navigation.PopAsync();


            }
            catch (Exception ex)
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Cancel");
            }
        }
    }
}