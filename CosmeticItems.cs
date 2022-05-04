using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalRisk
{
    public class CosmeticItems
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDateTime { get; set; }
        public CosmeticItems()
        {
            this.ItemName = "Abyssinia";
            this.Price = 14.99;
            this.ReleaseDateTime = new DateTime(1870 - 02 - 19);
        }
        public string OneLineSummary
        {
            get
            {
                return $"{this.ItemName} at {this.Price.ToString()}, released: "
                    + this.ReleaseDateTime.ToString("d");
            }
        }
    }
    public class CosmeticItemsViewModel
    {
        private CosmeticItems cosmeticItem = new CosmeticItems();
        public CosmeticItems CosmeticItem => this.cosmeticItem;

        private ObservableCollection<CosmeticItems> items = new ObservableCollection<CosmeticItems>();
        public ObservableCollection<CosmeticItems> Items { get { return this.items; } }
        public CosmeticItemsViewModel()
        {
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Cyclops",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1871 - 07 - 18)
            });
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Dévastation",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1879 - 08 - 19)
            });
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Hecate",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1871 - 09 - 30)
            });
            
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Hecate",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1871 - 09 - 30)
            });            
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Hecate",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1871 - 09 - 30)
            });            
            this.items.Add(new CosmeticItems()
            {
                ItemName = "Hecate",
                Price = 4.99,
                ReleaseDateTime = new DateTime(1871 - 09 - 30)
            });
        }
    }
}
