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
    public partial class main : Form
    {
        SearchBook searchBook;
        UpdateBook updateBook;

        public main()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

       
        
        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CloseAllChildForms();

            if (updateBook == null || updateBook.IsDisposed)
            {
                updateBook = new UpdateBook();
                updateBook.MdiParent = this;
            }
            updateBook.WindowState = FormWindowState.Maximized;
            updateBook.Show();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            CloseAllChildForms();

            if (searchBook == null || searchBook.IsDisposed)
            {
                searchBook = new SearchBook();
                searchBook.MdiParent = this;
            }
            searchBook.WindowState = FormWindowState.Maximized;
            searchBook.Show();
        }
    }
}
