using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionShopDatabase.Models
{
    public class Item
    {
        public int ItemID { get; }

        public string Name { get; }

        public string ItemDescription { get; }

        public List<string> Ingredients { get; }

        public decimal Price { get; }

        public PotionType PotionType { get; }

        public Item(int i, string n, string id, List<string> ingredients, decimal p, PotionType pt)
        {
            ItemID = i;
            Name = n;
            ItemDescription = id;
            Ingredients = ingredients;
            Price = p;
            PotionType = pt;
        }


    }
}
