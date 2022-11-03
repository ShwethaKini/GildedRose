
namespace csharp.Factory
{
    public class BackstagePassesItem : IItem
    {
        public readonly Item _item;
        public BackstagePassesItem(Item item)
        {
            _item = item;
        }
        public void Update()
        {
            _item.SellIn--;
            if (Helper.isMinSellInCrossed(_item))
            {
                _item.Quality = Constants.MIN_QUALITY;
                return;
            }
            _item.Quality++;
            if (Helper.isBackStageThreshold1Reached(_item))
                _item.Quality++;
            if (Helper.isBackStageThreshold2Reached(_item))
                _item.Quality++;
            if (Helper.isMaxQualityCrossed(_item))
                _item.Quality = Constants.MAX_QUALITY;
         
        }
    }
}
