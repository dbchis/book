using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BookBUS
    {
        BookDAL bookDAL = new BookDAL();
        public bool InsertBook(Book book)
        {
            return bookDAL.InsertBook(book);
        }
        public bool DeleteBook(string bookID)
        {
            return bookDAL.DeleteBook(bookID);
        }
        public bool UpdateBook(Book book)
        {
            return bookDAL.UpdateBook(book);
        }
        public List<Book> ListBook()
        {
            return bookDAL.ListBook();
        }
        public List<Book> SearchName(string nameBook)
        {
            return bookDAL.SearchName(nameBook);
        }
    }
}
