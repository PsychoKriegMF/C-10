using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_10
{
    public class BookStore<T> where T : IBook
    {
        private List<T> books = new List<T>();
        public void AddBook(T book) 
        {
            books.Add(book);
        }
        public void RemoveBook(T book)
        {
            books.Remove(book);
        }
        public IEnumerable<T> FindBooksByAuthor(string author)
        {
            return books.Where(b => b.Author == author);
        }
        public IEnumerable<T> FindBooksByGenre(string genre)
        {
            return books.Where(b => b.Genre == genre);
        }
        public IEnumerable<T> GetBooksSortedBy(Func<T,object> keySelector)
        {
            return books.OrderBy(keySelector);
        }
        public double CalculateTotalPrice()
        {
            return books.Sum(b => b.Price);
        }
        public T GetMostExpensiveBook()
        {
            return books.OrderByDescending(b => b.Price).FirstOrDefault();
        }
        


    }
}
