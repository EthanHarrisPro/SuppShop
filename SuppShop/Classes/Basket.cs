using System;
using System.Collections.Generic;
using System.Text;

namespace SuppShop.Classes
{
    public class Basket
    {

        List<Basket> basketlst = new();
        public string Name { get; set; }

        public string Desc { get; set; }

        public int Count { get; set; }

        public decimal Cost { get; set; }

        public void AddProduct(string name, string desc, int count, decimal cost)
        {
            Name = name;
            Desc = desc;
            Count = count;
            Cost = cost;
        }

        public void AddBasket(Basket basket)
        {
            basketlst.Add(basket);
        }

        public List<Basket> GetBasket()
        {
            return basketlst;
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (Basket b in basketlst)
            {
                
                total = total + (b.Cost * b.Count);
                


            }
            return total;
        }

}

    
}
