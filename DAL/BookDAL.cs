using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class BookDAL:DatabseConnection
    {
        public bool InsertBook(Book book)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into book values ('{book.BookID}',N'{book.BookName}','{book.Author}','{book.PublicationYear}')";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool DeleteBook(string bookID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from book where BOOK_ID='{bookID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }

        }
        public bool UpdateBook(Book book)
        {
            try
            {
                OpenConnection();
                string sql = $"update book set BOOKNAME=N'{book.BookName}',AUTHOR='{book.Author}',PUBLICATION_YEAR='{book.PublicationYear}' " +
                    $"where BOOK_ID='{book.BookID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public List<Book> ListBook()
        {
            List<Book> result = new List<Book>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Book";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string bookID = reader.GetString(0);
                string bookName = reader.GetString(1);
                string author = reader.GetString(2);
                int pubYear = reader.GetInt32(3);
                result.Add(new Book(bookID, bookName, author, pubYear));
            }
            reader.Close();
            CloseConnection();
            return result;

        }
        public List<Book> SearchName(string name)
        {
            List<Book> result = new List<Book>();
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"Select * from Book where BOOKNAME LIKE '%{name}%'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string bookID = reader.GetString(0);
                string bookName = reader.GetString(1);
                string author = reader.GetString(2);
                int pubYear = reader.GetInt32(3);
                result.Add(new Book(bookID, bookName, author, pubYear));
            }
            reader.Close();
            CloseConnection();
            return result;

        }

    }
}
