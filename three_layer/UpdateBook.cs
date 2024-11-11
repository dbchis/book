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
    public partial class UpdateBook : Form
    {
        BookBUS bookBUS = new BookBUS();
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book book = new Book(txtBookID.Text, txtBookName.Text, txtAuthor.Text, int.Parse(txtPubYear.Text));
            if (bookBUS.InsertBook(book))
                MessageBox.Show("Them thanh cong");
            else
                MessageBox.Show("Them that bai");
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookBUS.DeleteBook(txtBookID.Text))
                MessageBox.Show("Xoa thanh cong");
            else
                MessageBox.Show("Xoa that bai");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book(txtBookID.Text, txtBookName.Text, txtAuthor.Text, int.Parse(txtPubYear.Text));
            if (bookBUS.UpdateBook(book))
                MessageBox.Show("Cap nhat thanh cong");
            else
                MessageBox.Show("Cap nhat that bai");
        }
    }
}
