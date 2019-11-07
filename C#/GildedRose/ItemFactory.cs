using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using GildedRose.Model;

namespace GildedRose
{
     class ItemFactory
     {
         private static Dictionary<string, Func<CustomizedItem>> itemList = new Dictionary<string, Func<CustomizedItem>>
        {
            { "Aged Brie", () => new AgedBrieItem() },
            { "Sulfuras, Hand of Ragnaros", () => new LegendaryItem() },
            { "Backstage passes to a TAFKAL80ETC concert", () => new BackstageItem() },
            { "Conjured" , () => new ConjuredItem()}

        };

         public CustomizedItem Create(Item item)
        {
            if(!itemList.ContainsKey(item.Name)) return new RegularItem();
            return itemList[item.Name].Invoke();
        }
    }
}
