using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(Item item in Items)
            {
                UpdateQualityOfGenericItem(item);
                UpdateQualityAgedBrie(item);
                UpdateQualityBackstage(item);

                DecraseSellInDate(item);

                if (item.SellIn < 0)
                {
                    UpdateQualityAgedBrie(item);
                    if (!IsBackstagePass(item))
                    {
                        if (item.Quality > 0)
                        {
                            if (!IsLegendaryItem(item))
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }

            }
        }

        private void UpdateQualityAgedBrie(Item item)
        {
            if (IsAgedBrie(item))
            {
                if (item.Quality < 50)
                {

                    item.Quality = item.Quality + 1;


                    if (item.SellIn < 0)
                    {

                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }

        private void UpdateQualityOfGenericItem(Item item)
        {
            if (!IsAgedBrie(item) && !IsBackstagePass(item))
            {

                if (item.Quality > 0)
                {
                    if (!IsLegendaryItem(item))
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
                if(item.SellIn < 0 && item.Quality > 0)
                {
                    if (!IsLegendaryItem(item))
                    {
                        item.Quality = item.Quality - 2;
                    }

                }
               
            }
        }

        private void DecraseSellInDate(Item item)
        {
            if (!IsLegendaryItem(item))
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        private void UpdateQualityBackstage(Item item)
        {
            if (IsBackstagePass(item))
            {
                if (item.Quality < 50)
                {

                    item.Quality = item.Quality + 1;
                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                    }

                }
            }
            
        }

        private bool IsLegendaryItem(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private bool IsBackstagePass(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        private bool IsAgedBrie(Item item)
        {
            return item.Name == "Aged Brie";
        }
    }
}
