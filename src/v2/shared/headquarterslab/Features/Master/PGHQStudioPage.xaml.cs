using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace headquarterslab.Features.Master
{

    /// <summary>
    /// class PGHQStudioPage
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PGHQStudioPage : MasterDetailPage
    {

        /// <summary>
        /// PGHQStudioPage
        /// </summary>
        public PGHQStudioPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }


        /// <summary>
        /// ListView_ItemSelected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as PGHQStudioPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }


    }
}
