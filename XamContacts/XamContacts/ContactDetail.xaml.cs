using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamContacts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetail : ContentPage
    {
        public ContactDetail()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ContentPage_BindingContextChanged(object sender, EventArgs e)
        {
            contactImage.Source = ((Contact)sender).Image;
            contactName.Text = ((Contact)sender).DisplayName;
        }
    }
}