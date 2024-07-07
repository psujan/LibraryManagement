using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Core.Helpers;
using LibraryManagement.Model;


namespace LibraryManagement.Core
{
    public class BookController
    {
        private static List<Book> books = new List<Book>();


        public BookController()
        {
            Load();
        }

        

        private void Load()
        {
            
            Dictionary<string, object>[] bookList = BookList.bookList;

            foreach (var book in bookList)
            {
                // the line just below is a bad code call ! It works somehow !!
                Book bookObj = Helper.DictToObj<Book>(book);
                books.Add(bookObj);
            }

        }

        public Book? GetBookById(int id)
        {
           return books.Find((bk)=>bk.Id == id);
        }

        public List<Book> Index()
        {
            return books;
        }

        public Book GetBookByName(string name)
        {
            return null;
        }


        public List<Book> SortBookByPublicationDate()
        {
            return books.OrderBy((b) => b.PublishedYear).ToList();
        }

        public List<Book> SortBookByName()
        {
            return books.OrderBy((b) => b.Name).ToList();
        }

        public List<string> GetCategories()
        {
            List<string> categories =  new List<string>();
            return books.Select((b)=>b.Category).Distinct().ToList();
        }

        public List<Book> FindBookByCategory(string category)
        {
            return books.FindAll((b)=>b.Category.ToLower() == category.ToLower()).ToList();
        }
    }
}
