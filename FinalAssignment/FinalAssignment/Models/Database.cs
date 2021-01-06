using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignment.Models
{
    public class Database
    {
        public Books Books { get; set; }

        public Database()
        {
            string connString = "Server=DESKTOP-HE0MQ0Q\\SQLEXPRESS;Integrated Security=true;Database=book_m_s";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }
    }
}
