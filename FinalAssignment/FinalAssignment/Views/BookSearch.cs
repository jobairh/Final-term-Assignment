using FinalAssignment.Controller;
using FinalAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment.Views
{
    public partial class BookSearch : Form
    {
        public BookSearch()
        {
            InitializeComponent();
            var ds = BookController.GetAllBooks();
            dataGridViewAllBooks.DataSource = ds;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxSearch.Text;
            dynamic user = BookController.GetBook(username);
            if (user != null)
            {
                textBoxBookName.Text = user.Bookname;
                
            }
            else
            {
                textBoxBookName.Text = "";
                
                MessageBox.Show("No Bookname Found");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new NewBookAdd().Show();
        }

        private void dataGridViewAllBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book c = new Book();
            c.Id = Int32.Parse(this.dataGridViewAllBooks.CurrentRow.Cells[0].Value.ToString());
            c.Bookname = this.dataGridViewAllBooks.CurrentRow.Cells[1].Value.ToString();
            c.Author = this.dataGridViewAllBooks.CurrentRow.Cells[2].Value.ToString();
            c.Edition = this.dataGridViewAllBooks.CurrentRow.Cells[3].Value.ToString();
            new BookDetails(c).Show();
        }
        }
    }

