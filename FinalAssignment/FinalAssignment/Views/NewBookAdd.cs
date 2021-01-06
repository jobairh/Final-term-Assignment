using FinalAssignment.Controller;
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
    public partial class NewBookAdd : Form
    {
        public NewBookAdd()
        {
            InitializeComponent();
        }

        private void btnBookAdded_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Bookname = textBoxBookName.Text,
                Author = textBoxAuthor.Text,
                Edition = textBoxEdition.Text
            };
            var result = BookController.AddBook(user);
            if (result)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Could not Add Book");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BookSearch().Show();
        }
    }
}
