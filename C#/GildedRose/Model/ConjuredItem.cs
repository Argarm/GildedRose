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
            item.Quality -= IsInSellInPeriod(item) ? 2 : 4;
            if (item.Quality < 0) item.Quality = 0;
        }

        private static bool IsInSellInPeriod(Item item)
        {
            return item.SellIn >= 0;
        }

        private static void DecreaseSellInOfConjuredItem(Item item)
        {
            item.SellIn -= 1;
        }
    }
}
