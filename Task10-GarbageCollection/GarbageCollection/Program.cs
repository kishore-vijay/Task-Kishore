using System;
using System.Data.SqlClient;

class Program : IDisposable
{
    private SqlConnection connection;

    static void Main()
    {
        using (Program program = new Program())
        {
            program.Run();
        }
    }

    public Program()
    {
        string connectionString = "data source=ASPLAP2478;Encrypt=False;initial catalog=FoodDeliveryAppBase;trusted_connection=true";
        connection = new SqlConnection(connectionString);
        connection.Open();
    }

    public void Run()
    {
        try
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM Book_Details", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ? title = reader["bookTitle"].ToString();
                        string ? author = reader["bookAuthor"].ToString();
                        Console.WriteLine($"Title: {title}, Author: {author}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Dispose db Connection 
            if (connection != null)
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
                connection.Dispose();
                Console.WriteLine("Connection has been Disposed");
            }
        }
    }
}
