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
    public partial class DuyuruGoruntule : PhoneApplicationPage
    {
        public DuyuruGoruntule()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string link;

            if (NavigationContext.QueryString.TryGetValue("link", out link))
                 WebBrowser.Navigate(new Uri(link));
        }
    }
}