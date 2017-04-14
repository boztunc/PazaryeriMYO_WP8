using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PazaryeriMYO_WP8
{
    public partial class OgrBilgiSistemi : PhoneApplicationPage
    {
        public OgrBilgiSistemi()
        {
            InitializeComponent();
           
            

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string link;
            if (NavigationContext.QueryString.TryGetValue("link", out link)) 
            {
                webBrowserOGR.Navigate(new Uri(link)); 
            }
        }

        private void ContentPanel_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void webBrowserOGR_Navigating(object sender, NavigatingEventArgs e)
        {

        }

        private void webBrowserOGR_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}