using System;
using System.Collections;

namespace Demo.BookShop
{
    public class Book
    {
        public string Title;
        public String Author;
        public decimal Price;
    }

    public class Store : IEnumerable
    {
        public Book[] books;
        public IEnumerator GetEnumerator()
        {
            return new BookEnum(this);
        }
    }
    public class BookEnum : IEnumerator
    {
        int index;
        public Store  _store;
        Book _currentBook;
        public BookEnum(Store store)
        {
            _store=store;
            index=-1;
        }

        object IEnumerator.Current {
            get{
                return _currentBook;
            }
        }

        public bool MoveNext()
        {
            if(index<_store.books.Length-1)
            {
                _currentBook=_store.books[++index];
                return true;
            }
            else
            {
                this.Reset();
                return false;
            }
        }

        public void Reset()
        {
            index=-1;
        }
    }
}