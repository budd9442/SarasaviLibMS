using Microsoft.Data.SqlClient;
using System.Data;

namespace SarasaviLibMS.Classes;

public class Book
{
    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\budd\source\repos\SarasaviLibMS\bin\Debug\library.mdf;Integrated Security=True;Connect Timeout=30");
    public int id { get; set; }
    public char Classification { get; set; }
    public int Number { get; set; }
    public string? Title { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public bool Borrowable { get; set; }

    public virtual User Borrower { get; set; } = null!;

    public List<Book> fetchBooks()
    {
        var books = new List<Book>();
        if (connection.State != ConnectionState.Open)
        {
            try
            {
                connection.Open();
                string getData = "SELECT * FROM books";
                using (SqlCommand comm = new SqlCommand(getData, connection))
                {
                    Book book = new Book();
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        book.id = (int)reader["id"];
                        book.Classification = (char)reader["classification"];
                        book.Number = (int)reader["number"];
                        book.Title = (string)reader["title"];
                        book.Author = (string)reader["author"];
                        book.Borrowable = (int)reader["borrowable"]==1;
                        books.Add(book);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { connection.Close(); }
        }
        return books;
    }

}