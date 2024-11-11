using System;
namespace DTO
{
    class dd
    {
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public dd(string bookID, string bookName, string author, int pubYear)
        {
            BookID = bookID;
            BookName = bookName;
            Author = author;
            PublicationYear = pubYear;
        }

    }
}
