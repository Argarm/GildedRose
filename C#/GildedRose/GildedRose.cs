using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        private ItemFactory factory;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            factory = new ItemFactory();
        }

        public void UpdateQuality()
        {
            foreach(Item item in Items)
            {
                factory.Create(item).UpdateProductDetails(item);
            }
        }

    }
}
