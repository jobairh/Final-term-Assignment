using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Models
{
    public class Books
    {
        SqlConnection conn;
        public Books() { }

        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddBook(Book user)
        {
            conn.Open();
            string query = string.Format("INSERT INTO Books VALUES ('{0}','{1}','{2}')", user.Bookname, user.Author, user.Edition);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }
        public Book AuthenticateBook(string username, string password)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Books WHERE Bookname='{0}' AND Author='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Book user = null;
            while (reader.Read())
            {
                user = new Book();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Bookname = reader.GetString(reader.GetOrdinal("Bookname"));
                user.Author = reader.GetString(reader.GetOrdinal("Author"));
                user.Edition = reader.GetString(reader.GetOrdinal("Edition"));
            }
            conn.Close();
            return user;
        }

        public ArrayList GetAllBooks()
        {
            ArrayList Books = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book user = new Book();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Bookname = reader.GetString(reader.GetOrdinal("Bookname"));
                user.Author = reader.GetString(reader.GetOrdinal("Author"));
                user.Edition = reader.GetString(reader.GetOrdinal("Edition"));

                Books.Add(user);
            }
            conn.Close();
            return Books;
        }
        public Book GetBook(string username)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Books WHERE Bookname='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Book user = null;
            while (reader.Read())
            {
                user = new Book();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Bookname = reader.GetString(reader.GetOrdinal("Bookname"));
                user.Author = reader.GetString(reader.GetOrdinal("Author"));
                user.Edition = reader.GetString(reader.GetOrdinal("Edition"));
            }
            conn.Close();
            return user;
        }
    }
}
