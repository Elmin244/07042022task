using System;
using System.Collections.Generic;
using System.Text;

namespace _07042022task
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> _BookList;
        public Library()
        {
            _BookList = new List<Book>();
        }
        public void AddBook(Book book)
        {
            _BookList.Add(book);
        }
        public Book GetBookById(int id)
        {
            return _BookList.Find(x => x.Id == x.Id);
        }
        public void RemoveBook(int id)
        {
            var book = _BookList.Find(x => x.Id== id);
            _BookList.Remove(book);

        }

    }
}
