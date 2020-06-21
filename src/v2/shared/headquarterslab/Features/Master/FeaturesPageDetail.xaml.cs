using System;
using System.Collections.Generic;
using headquarterslab.Constants;
using headquarterslab.Models;
using Xamarin.Forms;

namespace headquarterslab.Features.Master
{

    /// <summary>
    /// 
    /// </summary>
    public partial class FeaturesPageDetail : ContentPage
    { 
        /// <summary>
        /// 
        /// </summary>
        public FeaturesPageDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        async void OnButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");

            DBServerItem item = new DBServerItem();

            item.Id             = 0;
            item.Dbport         = "5432";
            item.Servername     = "127.0.0.1";
            item.Description    = "";
            item.Username       = "postgres";
            item.Password       = "";

            await GlobalDB.Database.SaveItemAsync(item);

        }
    }
}
