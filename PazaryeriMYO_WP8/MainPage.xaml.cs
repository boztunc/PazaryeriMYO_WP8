using System;
using System.Net;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using HtmlAgilityPack;
using System.Collections.ObjectModel;








namespace PazaryeriMYO_WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor

        public ObservableCollection<String> StringsList { get; set; }
        public ObservableCollection<String> LinkStringsList { get; set; }

        public MainPage()
        {

            TiltEffect.TiltableItems.Add(typeof(HubTile));
            
            InitializeComponent();
            
           



            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            try
            {
                HttpWebRequest WebRequest = (HttpWebRequest)HttpWebRequest.Create("http://pazaryeri.bilecik.edu.tr/TumDuyurular.aspx");
                WebClient client = new WebClient();
                Uri uri = new Uri("http://pazaryeri.bilecik.edu.tr/TumDuyurular.aspx");
                client.DownloadStringAsync(uri);
                client.DownloadStringCompleted += client_DownloadStringCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz");
            }
            
            
            
            

            

        }

        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlDocument();
                dokuman.LoadHtml(e.Result);
                HtmlNodeCollection duyurular = dokuman.DocumentNode.SelectNodes("//a[@id='HLBaslik']");

                StringsList = new ObservableCollection<string> { };
                LinkStringsList = new ObservableCollection<string> { };


                foreach (var item in duyurular)
                {
                    StringsList.Add("►" + item.InnerText + "\n");
                    LinkStringsList.Add(item.Attributes["href"].Value);
                }


                link1.Content = StringsList[0];
                link2.Content = StringsList[1];
                link3.Content = StringsList[2];
                link4.Content = StringsList[3];
                link5.Content = StringsList[4];
                link6.Content = StringsList[5];
                link7.Content = StringsList[6];
                link8.Content = StringsList[7];
                link9.Content = StringsList[8];
                link10.Content = StringsList[9];
                link11.Content = StringsList[10];
                link12.Content = StringsList[11];
                link13.Content = StringsList[12];
                link14.Content = StringsList[13];
                link15.Content = StringsList[14];
                link16.Content = StringsList[15];
                link17.Content = StringsList[16];
                link18.Content = StringsList[17];
                link19.Content = StringsList[18];
                link20.Content = StringsList[19];
            }
            catch (Exception)
            {

                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz");
            }
           
            
             

        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void link1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link="+"http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[0], UriKind.Relative));            
        }

        private void link2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[1], UriKind.Relative));            
        }

        private void link3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[2], UriKind.Relative));            
        }

        private void link4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[3], UriKind.Relative));
        }

        private void link5_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[4], UriKind.Relative));            
        }

        private void link6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[5], UriKind.Relative));
        }

        private void link7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[6], UriKind.Relative));
        }

        private void link8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[7], UriKind.Relative));
        }

        private void link9_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[8], UriKind.Relative));
        }

        private void link10_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[9], UriKind.Relative));
        }

        private void link11_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[10], UriKind.Relative));
        }

        private void link12_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[11], UriKind.Relative));
        }

        private void link13_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[12], UriKind.Relative));
        }

        private void link14_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[13], UriKind.Relative));
        }

        private void link15_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[14], UriKind.Relative));
        }

        private void link16_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[15], UriKind.Relative));
        }
        private void link17_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[16], UriKind.Relative));
        }
        private void link18_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[17], UriKind.Relative));
        }
        private void link19_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[18], UriKind.Relative));
        }
        private void link20_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/" + LinkStringsList[19], UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DuyuruGoruntule.xaml", UriKind.Relative));
        }

        private void maps_TextInputStart(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

        }

        private void HT_OgrIsleri_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void HT_OgrIsleri_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "https://obs.bilecik.edu.tr/login.aspx?ReturnUrl=/default.aspx", UriKind.Relative)); 
        }

        private void HT_tlfNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://rehber.bilecik.edu.tr/", UriKind.Relative)); 
        }

        private void HT_YemekM_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://sks.bilecik.edu.tr/IcerikDetay.aspx?No=205", UriKind.Relative)); 
        }

        private void HT_AkTakvim_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://www.bilecik.edu.tr/Icerik/IcerikDetay.aspx?No=1", UriKind.Relative)); 
        }

        private void HT_FotoGaleri_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/IcerikDetay.aspx?No=54", UriKind.Relative)); 
        }

        private void HT_AkPersonel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/IcerikDetay.aspx?No=23", UriKind.Relative)); 
        }

        private void HT_BilecikUni_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://www.bilecik.edu.tr/", UriKind.Relative)); 
        }

        private void HT_Iletisim_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/KısayollarGoruntule.xaml?link=" + "http://pazaryeri.bilecik.edu.tr/Iletisim.aspx", UriKind.Relative)); 
        }

        private void Map_Link_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GenisHarita.xaml", UriKind.Relative)); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/yonetim.xaml", UriKind.Relative));
        }

        

       

    }
}
