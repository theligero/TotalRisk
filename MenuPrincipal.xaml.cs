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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace TotalRisk
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            StandardPopup.IsOpen = false;
        }

        private void Individual_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TabPage), "single");
        }

        private void Cooperativo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TabPage), "coop");
        }

        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            if (!StandardPopup.IsOpen) StandardPopup.IsOpen = true;
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (StandardPopup.IsOpen) StandardPopup.IsOpen = false;
        }
    }
}
