using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Model
{
    class ConjuredItem : CustomizedItem
    {
        public override void UpdateProductDetails(Item item)
        {
            item.SellIn -= 1;
            if (item.SellIn < 0 && item.Quality > 4) { item.Quality -= 4; return; }
            if (item.Quality > 1) {item.Quality -= 2; return;}
            item.Quality = 0;
        }
    }
}
