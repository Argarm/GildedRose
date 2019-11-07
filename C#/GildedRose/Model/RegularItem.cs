using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class RegularItem : CustomizedItem
    {
        private static int MINIMUM_QUALITY = 0;
        public override void UpdateProductDetails(Item item)
        {
            if (item.Quality > MINIMUM_QUALITY) item.Quality -= 1;
            if (item.SellIn <= 0) item.Quality -= 1;
            if (item.Quality < MINIMUM_QUALITY) item.Quality = MINIMUM_QUALITY;
            item.SellIn -= 1;
        }
    }
}
