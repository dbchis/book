using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Book
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public Book(string bookID, string bookName, string author, int pubYear)
        {
            BookID = bookID;
            BookName = bookName;
            Author = author;
            PublicationYear = pubYear;
        }
    }
}
