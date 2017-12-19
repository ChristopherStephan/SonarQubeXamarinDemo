using System;

using Xamarin.Forms;

namespace SonarQube
{
    public class App : Application
    {
        public App()
        {
            var content = new ContentPage
            {
                Title = "SonarQube",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "SonarQube Test"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        static void asd(string[] args)
        {
            var iAmTrue = true;
            if (iAmTrue)
            {
                System.Diagnostics.Debug.WriteLine("true");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("false");
            }

        }

        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
