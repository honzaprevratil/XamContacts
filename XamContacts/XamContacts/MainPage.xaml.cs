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
            contacts.Add(new Contact { DisplayName = "Rob Finnerty", Image = "avatar.png" });
            contacts.Add(new Contact { DisplayName = "Bill Wrestler", Image = "avatar.png" });
            contacts.Add(new Contact { DisplayName = "Dr. Geri-Beth Hooper", Image = "avatar.png" });
            contacts.Add(new Contact { DisplayName = "Dr. Keith Joyce-Purdy", Image = "avatar.png" });
            contacts.Add(new Contact { DisplayName = "Sheri Spruce", Image = "avatar.png" });
            contacts.Add(new Contact { DisplayName = "Burt Indybrick", Image = "avatar.png" });
        }

        private void ContacsView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            App.Current.BindingContext = sender;
            Navigation.PushModalAsync(contactDetail);
        }
    }
}
