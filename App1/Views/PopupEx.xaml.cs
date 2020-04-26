using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1.Views
{
    public partial class PopupEx : ContentPage
    {
        public PopupEx()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //var reponse = await DisplayAlert("Worning", "Do you really want to Delete!??", "Ok", "Cancel");
            //if (reponse)
            //{
            //    await DisplayAlert("Confirmation", "Deleted", "OK");
            //}

            var response = await DisplayActionSheet("Choose Options", "Cancel", "Delete", "Share Linke", "Email", "Download", "Copy");
            await DisplayAlert("User Choice", response, "Cancel");

        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new );
        }
    }
}
