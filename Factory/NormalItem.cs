

namespace csharp.Factory
{
    public class NormalItem : IItem
    {
        public readonly Item _item;
        public NormalItem(Item item)
        {
            _item = item;
        }
        public void Update()
        {
            _item.SellIn--;
            if (_item.Quality > Constants.MIN_QUALITY)
                _item.Quality--;
            if(Helper.isMinSellInCrossed(_item))
                _item.Quality--;
            if (Helper.isMinQualityCrossed(_item))
                _item.Quality = Constants.MIN_QUALITY;
           
        }
    }
}
