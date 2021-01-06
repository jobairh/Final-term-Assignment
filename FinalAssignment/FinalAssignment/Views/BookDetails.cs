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
    public partial class BookDetails : Form
    {
        public BookDetails(Book obj)
        {
            InitializeComponent();
            textBoxId.Text = obj.Id.ToString();
            textBoxBookName.Text = obj.Bookname;
            textBoxAuthor.Text = obj.Author;
            textBoxEdition.Text = obj.Edition;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new BookSearch().Show();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
