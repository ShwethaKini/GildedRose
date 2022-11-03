

namespace csharp.Factory
{
    public class ConjuredItem : IItem
    {
        public readonly Item _item;
        public ConjuredItem(Item item)
        {
            _item = item;
        }
        public void Update()
        {
            _item.SellIn--;
            _item.Quality = _item.Quality - 2;
            if(Helper.isMinSellInCrossed(_item))
                _item.Quality = _item.Quality - 2;
            if (Helper.isMinQualityCrossed(_item))
                _item.Quality = Constants.MIN_QUALITY;
        }
    }
}
