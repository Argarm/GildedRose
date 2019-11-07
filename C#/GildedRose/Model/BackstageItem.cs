using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class BackstageItem : CustomizedItem
    {
        private static int INCREASE_QUALITY_RATE = 1;
        private static int START_DAY_TO_INCREASE_QUALITY_BY_TWO=10;
        private static int START_DAY_TO_INCREASE_QUALITY_BY_THREE = 5;
        private static int LIMIT_DAY_TO_DROP_QUALITY = 0;

        public override void UpdateProductDetails(Item item)
        {
            DecreaseSellInOfBackstagePass(item);
            UpdateQualityOfBackstagePass(item);
        }

        private static void UpdateQualityOfBackstagePass(Item item)
        {
            item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn < START_DAY_TO_INCREASE_QUALITY_BY_TWO) item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn < START_DAY_TO_INCREASE_QUALITY_BY_THREE) item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn < LIMIT_DAY_TO_DROP_QUALITY) item.Quality = 0;
        }

        private static void DecreaseSellInOfBackstagePass(Item item)
        {
            item.SellIn -= 1;
        }
    }
}
