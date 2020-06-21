using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace headquarterslab.Features.Master
{


    /// <summary>
    /// class PGHQStudioPageMaster
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PGHQStudioPageMaster : ContentPage
    {
        public ListView ListView;


        /// <summary>
        /// PGHQStudioPageMaster
        /// </summary>
        public PGHQStudioPageMaster()
        {
            InitializeComponent();

            BindingContext = new PGHQStudioPageMasterViewModel();
            ListView = MenuItemsListView;
        }




        /// <summary>
        /// class PGHQStudioPageMasterViewModel
        /// </summary>
        class PGHQStudioPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<PGHQStudioPageMenuItem> MenuItems { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public PGHQStudioPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<PGHQStudioPageMenuItem>(new[]
                {
                    new PGHQStudioPageMenuItem { Id = 0, Title = "Main Features", TargetType = typeof(FeaturesPageDetail)}
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
