using FinalAssignment.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Controller
{
    public class BookController
    {
        static Database db = new Database();
        public static Book AuthenticateBook(string username, string password)
        {
            return db.Books.AuthenticateBook(username, password);
        }
        public static bool AddBook(dynamic user)
        {
            Book u = new Book();
            u.Bookname = user.Bookname;
            u.Author = user.Author;
            u.Edition = user.Edition;
            //var u = (User)user;//boxing---> it was not working because this is user type and registration form btnclick is anonymous type

            return db.Books.AddBook(u);
        }
        public static Book GetBook(string username)
        {
            return db.Books.GetBook(username);
        }
        public static ArrayList GetAllBooks()
        {
            return db.Books.GetAllBooks();
        }
    }
}
