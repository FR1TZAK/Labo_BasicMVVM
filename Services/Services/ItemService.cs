using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class ItemService
    {
        public ItemService()
        {

        }
        public List<Item> GenerateItems()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { ID = 1, ItemName = "Andariel", Status = "Dead" });
            items.Add(new Item() { ID = 2, ItemName = "Duriel", Status = "Dead" });
            items.Add(new Item() { ID = 3, ItemName = "Mephisto", Status = "Dead" });
            items.Add(new Item() { ID = 4, ItemName = "Diablo", Status = "Dead" });
            items.Add(new Item() { ID = 5, ItemName = "Baal", Status = "Alive" });

            return items;
        }
    }
}
