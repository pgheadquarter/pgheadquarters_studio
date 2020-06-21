using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using headquarterslab.Features.Master;

namespace headquarterslab
{

    /// <summary>
    /// class App
    /// </summary>
    public partial class App : Application
    {

        /// <summary>
        /// App
        /// </summary>
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new PGHQStudioPage();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnResume()
        {
        }

    }
}
