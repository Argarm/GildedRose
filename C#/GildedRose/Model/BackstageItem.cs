using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class BackstageItem : CustomizedItem
    {
        private static int INCREASE_QUALITY_RATE = 1;
        
        public override void UpdateProductDetails(Item item)
        {
            
            item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn <= 10) item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn <= 5) item.Quality += INCREASE_QUALITY_RATE;
            if (item.SellIn == 0) item.Quality = 0; 
            item.SellIn -= 1;
            

        }
    }
}
