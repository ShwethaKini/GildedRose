

namespace csharp.Factory
{
    public class AgedBrieItem : IItem
    {
        public readonly Item _item;
        public AgedBrieItem(Item item)
        {
            _item = item;
        }
         public void Update()
        {
            _item.SellIn--;
            _item.Quality++;
            if (Helper.isMinSellInCrossed(_item))
                _item.Quality++;
            if (Helper.isMaxQualityCrossed(_item))
                _item.Quality = Constants.MAX_QUALITY;
        }
    }
}
