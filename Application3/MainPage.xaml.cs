using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Application3
{
   public class MyItem
    {
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        List<MyItem> ListImages = new List<MyItem>();
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitImage();
            flipview.ItemsSource = ListImages;
        }

        private void InitImage()
        {
            ListImages.Add(new MyItem { ImageName = "Bat", ImagePath = "ms-appx:///Assets/Images/1.jpg" });
            ListImages.Add(new MyItem { ImageName = "Bati", ImagePath = "ms-appx:///Assets/Images/11.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batis", ImagePath = "ms-appx:///Assets/Images/121678.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batiss", ImagePath = "ms-appx:///Assets/Images/185464.jpg" });
            ListImages.Add(new MyItem { ImageName = "TIENTCHEU_ISRAEL_Nom", ImagePath = "ms-appx:///Assets/Images/12.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissat", ImagePath = "ms-appx:///Assets/Images/375.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissati", ImagePath = "ms-appx:///Assets/Images/318728.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis", ImagePath = "ms-appx:///Assets/Images/1170799.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_", ImagePath = "ms-appx:///Assets/Images/563119.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_b", ImagePath = "ms-appx:///Assets/Images/596848.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_be", ImagePath = "ms-appx:///Assets/Images/599379.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_bet", ImagePath = "ms-appx:///Assets/Images/629544.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_bete", ImagePath = "ms-appx:///Assets/Images/653529.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_bete_", ImagePath = "ms-appx:///Assets/Images/677543.jpg" });
            ListImages.Add(new MyItem { ImageName = "Batissatis_bete_N", ImagePath = "ms-appx:///Assets/Images/698363.png" });
            ListImages.Add(new MyItem { ImageName = "SW0RD_ART_ONLINE", ImagePath = "ms-appx:///Assets/Images/964825.jpg" });
            ListImages.Add(new MyItem { ImageName = "TIENTCHEU_ISRAEL_Nom", ImagePath = "ms-appx:///Assets/Images/12.jpg" });
        }
    }
}
