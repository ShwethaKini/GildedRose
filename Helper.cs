
namespace csharp
{
    public static class Helper
    {
        public static bool isMaxQualityCrossed(Item item)
        {
            return item.Quality > Constants.MAX_QUALITY;
        }
        public static bool isMinQualityCrossed(Item item)
        {
            return item.Quality < Constants.MIN_QUALITY;
        }
        public static bool isMinSellInCrossed(Item item)
        {
            return item.SellIn < 0;
        }
        public static bool isBackStageThreshold1Reached(Item item)
        {
            return item.SellIn < Constants.BACKSTAGE_SELLIN_THRESHOLD1;
        }
        public static bool isBackStageThreshold2Reached(Item item)
        {
            return item.SellIn < Constants.BACKSTAGE_SELLIN_THRESHOLD2;
        }
    }
}
