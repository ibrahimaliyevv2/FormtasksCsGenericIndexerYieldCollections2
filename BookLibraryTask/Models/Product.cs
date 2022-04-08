using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Product
    {
        public Product()
        {
            _id++;
            Id = _id;
        }

        private int _id;
        public int Id { get; protected set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome{get; protected set; }

        public abstract void Sell();

        public abstract void ShowInfo();
    }
}
