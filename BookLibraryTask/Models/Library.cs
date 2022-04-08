using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Models
{
    public class Library
    {
        public int BookLimit { get; set; }
        List<Book> Books = new List<Book>();

        public void AddBook(Book book)
        {
            if (Books.Count <= BookLimit)
            {
                Books.Add(book);
            }
            else
            {
                throw new CapacityLimitException("Capacity is full!");
            }
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (var item in Books)
                {
                    if (item.Id == id)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public void RemoveById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else{
                foreach (var item in Books)
                {
                    if (item.Id == id)
                    {
                        Books.Remove(item);
                    }
                    else if (item.Id != id)
                    {
                        throw new NotFoundException("Searched Id is not founded!");
                    }
                }
            }
        }
    }
}
