using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace TotalRisk
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PartidaOnline : Page
    {
        ObservableCollection<String> civs = new ObservableCollection<string>();
        public PartidaOnline()
        {
            this.InitializeComponent();
            civs.Add("Nubia");
            civs.Add("Egipto");
            civs.Add("Alemania");
            civs.Add("España");
            civs.Add("EEUU");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape) 
                App.TryGoBack();
        }

        private void VSButton_Click(object sender, RoutedEventArgs e)
        {
            VSButton.Content = "Buscando...";
            CancelButton.Visibility = Visibility.Visible;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            VSButton.Content = "JUGAR";
            CancelButton.Visibility = Visibility.Collapsed;
        }

        private void CoopButton_Click(object sender, RoutedEventArgs e)
        {
            if (CoopButton.Content.ToString() != "Cancelar búsqueda") CoopButton.Content = "Cancelar búsqueda";
            else CoopButton.Content = "JUGAR";
        }
    }
}
