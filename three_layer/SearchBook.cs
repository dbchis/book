using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
namespace GUI_STUDENT_MANAGEMENT

{
    public partial class SearchBook : Form
    {
        BookBUS bookBUS = new BookBUS();
        List<Book> books;

        public SearchBook()
        {
            InitializeComponent();
            books = bookBUS.ListBook();
            ShowList(books);
        }
        public void ShowList(List<Book> books)
        {
            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.BookID);
                item.SubItems.Add(book.BookName);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.PublicationYear.ToString());
                listView1.Items.Add(item);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            books = bookBUS.SearchName(txtSearchName.Text);
            ShowList(books);
        }

        /* private void SearchBook_Load(object sender, EventArgs e)
         {
             Show();
         }*/
    }
}
