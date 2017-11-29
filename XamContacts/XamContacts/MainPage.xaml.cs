using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamContacts
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
        public ContactDetail contactDetail = new ContactDetail();
        public MainPage()
        {
            InitializeComponent();
            //defined in XAML to follow
            ContacsView.ItemsSource = contacts;
            contacts.Add(new Contact { DisplayName = "Rob Finnerty", Image = "avatar.png", Number = "695 221 432" });
            contacts.Add(new Contact { DisplayName = "Bill Wrestler", Image = "avatar.png", Number = "629 911 352" });
            contacts.Add(new Contact { DisplayName = "Dr. Geri-Beth Hooper", Image = "avatar.png", Number = "725 366 248" });
            contacts.Add(new Contact { DisplayName = "Dr. Keith Joyce", Image = "avatar.png", Number = "770 845 567" });
            contacts.Add(new Contact { DisplayName = "Sheri Spruce", Image = "avatar.png", Number = "671 112 379" });
            contacts.Add(new Contact { DisplayName = "Burt Indybrick", Image = "avatar.png", Number = "744 241 840" });
        }

        private void ContacsView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            contactDetail.BindingContext = ContacsView.SelectedItem;
            Navigation.PushModalAsync(contactDetail);
        }
    }
}
