using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    class LegendaryItem : CustomizedItem
    {
        public override void UpdateProductDetails(Item item)
        {
            item.Quality +=0;
        }
    }
}
