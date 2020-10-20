using System;
using CoAway.Models;
using CoAway.Views.FoodAccess;
using CoAway.Views.Forms;
using CoAway.Views.Onboarding;
using CoAway.Views.PublicService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoAway
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public static CoAwaySystemConfig UserSession { get; set; }
        public static string DefaultImageId = "default_image";
        public static string ImageIdToSave = null;

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzEyODU4QDMxMzgyZTMyMmUzMFRWckpyM3FnUG1lZW41NnBDKzFNbU80K0I4bXAzTWxtYUxsdnV3N0MreDA9");

            InitializeComponent();

           //MainPage = new NavigationPage(new Views.Navigation.SelectableNamePage());
            MainPage = new NavigationPage(new  Views.Onboarding.OnboardingLocation());
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new  Views.Onboarding.InstructionPage());
            //MainPage = new NavigationPage(new Views.PublicService.publicServiceIncidentDes())
        }



        protected override void OnStart()
        {
            if (App.UserSession == null)
            {
                App.UserSession = new CoAwaySystemConfig();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
    public class CoAwaySystemConfig
    {
        public CoAwaySystemConfig()
        {
            CurrentUserInfo = new User();
        }
        public User CurrentUserInfo { get; set; }
    }
}
