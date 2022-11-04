

namespace csharp.Factory
{
    public class GildedRoseFactory
    {
        private readonly IItem newInstance;
        public GildedRoseFactory(Item item)
        {
            switch (item.Name)
            {
                case Constants.AGERD_BRIE:
                    newInstance = new AgedBrieItem(item);
                    break;
                case Constants.BACKSTAGE_PASSES:
                    newInstance = new BackstagePassesItem(item);
                    break;
                case Constants.CONJURED:
                    newInstance = new ConjuredItem(item);
                    break;
                default:
                    newInstance = new NormalItem(item);
                    break;
            }
        }
        public void Update()
        {
            newInstance.Update();
        }
            
        
    }
}
