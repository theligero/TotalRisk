using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class TiendaDLC : Page
    {
        public TiendaDLC()
        {
            this.InitializeComponent();
        }

        private void latestDLC_Click(object sender, RoutedEventArgs e)
        {
            ShowBuyDialogButton_Click(sender, e);        
        }

        private async void ShowBuyDialogButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialogResult result = await buyDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                Button addedItem = (Button)e.OriginalSource;
                string dlc = addedItem.Name;
                await new MessageDialog("Has adquirido " + dlc, "Compra realizada con éxito").ShowAsync();
            }
            else
            {
                // User pressed Cancel, ESC, or the back arrow.
                // Terms of use were not accepted.
            }
        }

        private void ConfirmBuyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            buyDialog.IsPrimaryButtonEnabled = true;
        }

        private void ConfirmBuyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            buyDialog.IsPrimaryButtonEnabled = false;
        }

        private void buyDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
        {
            ConfirmBuyCheckBox.IsChecked = false;
        }
    }
}
