using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace TotalRisk
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 

    public sealed partial class TiendaCosmeticos : Page
    {
        private List<CosmeticItems> basket = new List<CosmeticItems>
        {
        };
        public TiendaCosmeticos()
        {
            this.InitializeComponent();
            this.ViewModel = new CosmeticItemsViewModel();
        }

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    // Cosntruye las listas de ModelView a partir de la lista Modelo 
        //    if (ViewModel.Items != null)
        //        foreach (CosmeticItems cosit in ViewModel.Items)
        //        {
        //            DataTemplate
        //        }
        //    base.OnNavigatedTo(e);
        //}

        public CosmeticItemsViewModel ViewModel { get; }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            CosmeticItems addedItem = (CosmeticItems)e.ClickedItem;
            basket.Add(addedItem);
        }

        private void basketButton_Click(object sender, RoutedEventArgs e)
        {
            Nav_Pop.IsOpen = true;

            double total = 0;
            if (basket.Count > 0)
            {
                foreach (CosmeticItems cos in basket)
                {
                    if (cestavacia != null) BasketStackPanel.Children.Remove(cestavacia);
                    TextBlock basketitem = new TextBlock();
                    basketitem.Text = cos.ItemName;
                    basketitem.FontSize = 24.667;
                    BasketStackPanel.Children.Add(basketitem);
                    TextBlock basketitemPrice = new TextBlock();
                    basketitemPrice.Text = cos.Price.ToString() + "$";
                    basketitemPrice.FontSize = 24.667;
                    basketitemPrice.HorizontalAlignment = HorizontalAlignment.Right;
                    BasketStackPanel.Children.Add(basketitemPrice);
                    total += cos.Price;
                }

                TextBlock totalPrice = new TextBlock();
                totalPrice.Text = "Total: " + total.ToString() + "$";
                totalPrice.FontSize = 24.667;
                totalPrice.HorizontalAlignment = HorizontalAlignment.Right;
                totalPrice.VerticalAlignment = VerticalAlignment.Bottom;
                BasketStackPanel.Children.Add(totalPrice);
            }
        }

        private void Nav_Pop_Closed(object sender, object e)
        {
            BasketStackPanel.Children.Clear();
            TextBlock basketitem = new TextBlock();
            basketitem.Text = "Tu cesta: ";
            basketitem.FontSize = 24.667;
            basketitem.HorizontalAlignment = HorizontalAlignment.Center;
            basketitem.VerticalAlignment = VerticalAlignment.Top;
            BasketStackPanel.Children.Add(basketitem);
        }
    }
}
