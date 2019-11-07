using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    class ConjuredItem : CustomizedItem
    {
        public override void UpdateProductDetails(Item item)
        {
            DecreaseSellInOfConjuredItem(item);
            UpdateQualityOfConjuredItem(item);
        }

        private static void UpdateQualityOfConjuredItem(Item item)
        {
            if (item.SellIn < 0 && item.Quality > 4)
            {
                item.Quality -= 4;
                return;
            }

            if (item.Quality > 1)
            {
                item.Quality -= 2;
                return;
            }

            item.Quality = 0;
        }

        private static void DecreaseSellInOfConjuredItem(Item item)
        {
            item.SellIn -= 1;
        }
    }
}
