using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace csharp
{
    public class GildedRoseTest
    {
        [Fact]
        public void AgedBrei_Should_Increase_Quantity_As_Sell_Days_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(1);
            Items[0].SellIn.Should().Be(1);
        }

        [Fact]
        public void AgedBrei_Should_Not_Increase_Quantity_When_It_Reaches_Maximum()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(50);
            Items[0].SellIn.Should().Be(1);
        }
        [Fact]
        public void AgedBrei_Should_Increase_Quantity_Twice_When_Sell_In_Date_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(7);
            Items[0].SellIn.Should().Be(-1);
        }
        [Fact]
        public void Backstage_Passes_Should_Increase_Quantity_As_Sell_Days_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(1);
            Items[0].SellIn.Should().Be(11);
        }

        [Fact]
        public void Backstage_Passes_Should_Not_Increase_Quantity_When_It_Reaches_Maximum()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(50);
            Items[0].SellIn.Should().Be(9);
        }
        [Fact]
        public void Backstage_Passes_Should_Drop_Quality_To_0_When_Sell_In_Date_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(0);
            Items[0].SellIn.Should().Be(-1);
        }
        [Fact]
        public void Backstage_Passes_Should_Increase_Quality_By_Twice_When_Sell_In_Date_Becomes_10_Or_Less()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(7);
            Items[0].SellIn.Should().Be(10);
        }
        [Fact]
        public void Backstage_Passes_Should_Increase_Quality_By_Twice_When_Sell_In_Date_Becomes_5_Or_Less()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(8);
            Items[0].SellIn.Should().Be(5);
        }
        [Fact]
        public void Normal_Item_Should_Decrease_Quantity_As_Sell_Days_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 2, Quality = 4 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(3);
            Items[0].SellIn.Should().Be(1);
        }

        [Fact]
        public void Normal_Item_Should_Not_Decrease_Quantity_When_It_Reaches_0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(0);
            Items[0].SellIn.Should().Be(1);
        }
        [Fact]
        public void Normal_Item_Should_Decrease_Quantity_Twice_When_Sell_In_Date_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(3);
            Items[0].SellIn.Should().Be(-1);
        }
        [Fact]
        public void Conjured_Item_Should_Decrease_Quantity_Twice_The_Other_Items_As_Sell_Days_Decreases()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 4 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(2);
            Items[0].SellIn.Should().Be(1);
        }

        [Fact]
        public void Conjured_Item_Should_Not_Decrease_Quantity_When_It_Reaches_0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 2, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(0);
            Items[0].SellIn.Should().Be(1);
        }
        [Fact]
        public void Conjured_Item_Should_Decrease_Quantity_Four_Times_When_Sell_In_Date_Passes()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 8 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(4);
            Items[0].SellIn.Should().Be(-1);
        }
        [Fact]
        public void Sulfuras_Item_Should_Maintain_Sellin_Value_And_Quantity_Without_Any_Change()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 8 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Quality.Should().Be(8);
            Items[0].SellIn.Should().Be(-1);
        }
    }
}
