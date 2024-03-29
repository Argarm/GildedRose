﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class AgedBrieItem : CustomizedItem
    {
        private static int MAXIMUM_QUALITY = 50;
        public override void UpdateProductDetails(Item item)
        {
            DescreaseSellInOfAgedBrie(item);
            UpdateQualityOfAgedBrie(item);
        }

        private static void UpdateQualityOfAgedBrie(Item item)
        {
            if (item.Quality < MAXIMUM_QUALITY) item.Quality += 1;
        }

        private static void DescreaseSellInOfAgedBrie(Item item)
        {
            item.SellIn -= 1;
        }
    }
}
