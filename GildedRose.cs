using csharp.Factory;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()

        {
            foreach (var item in Items)
            {
                if (item.Name.Equals(Constants.SULFURAS))
                    continue;
                GildedRoseFactory factory = new GildedRoseFactory(item);
                factory.Update();
            }

        }
    }
}
