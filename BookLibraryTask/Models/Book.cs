using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Models
{
    public class Book : Product
    {
        public Book(string name, double price, string authorName, int pageCount, int count)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count = count;
        }

        public override void Sell()
        {
            if (Count>0) {
                Count--;
                TotalInCome += Price;
            }
            else
            {
                throw new ProductCountIsZeroException("Product count iz zero!");
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Count: {Count}, Total Income: {TotalInCome}, Author name: {AuthorName}, Page count: {PageCount}");
        }

        public string AuthorName { get; set; }
        public int PageCount { get; set; }

    }
}
