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


        public decimal Price { get; }

        //public PotionType PotionTypeID { get; }
        public PotionType PotionTypeID { get; }
        public Item(int i, string n, decimal p, PotionType pt)
        {
            ItemID = i;
            Name = n;
            Price = p;
            PotionTypeID = pt;
        }


    }
}
