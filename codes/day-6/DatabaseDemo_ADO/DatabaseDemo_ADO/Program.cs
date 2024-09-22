using Microsoft.Data.SqlClient;

AddData();
FetchData();

static void FetchData()
{
    SqlConnection? connection = null;
    SqlCommand? command = null;
    SqlDataReader? reader = null;

    try
    {
        connection = new SqlConnection(@"server=joydip-pc\sqlexpress;database=siemensdb;user id=sa;password=sqlserver2024;TrustServerCertificate=True");
        connection.Open();
        //Console.WriteLine(connection.State.ToString());
        command = connection.CreateCommand();
        command.CommandText = "select * from products";

        reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine(reader["id"].ToString() + " " + reader["name"].ToString() + reader["price"].ToString());
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    finally
    {
        reader?.Close();
        connection?.Close();
    }
}

static void AddData()
{
    SqlConnection? connection = null;
    SqlCommand? command = null;

    try
    {
        connection = new SqlConnection(@"server=joydip-pc\sqlexpress;database=siemensdb;user id=sa;password=sqlserver2024;TrustServerCertificate=True");

        //Console.WriteLine(connection.State.ToString());
        command = connection.CreateCommand();
        //command.CommandText = "insert into products(name,price,description,category_id) values(@name,@price,@desc,@cid)";
        command.CommandText = "sp_addproduct";
        command.CommandType = System.Data.CommandType.StoredProcedure;

        command.Parameters.AddWithValue("@name", "sample");
        command.Parameters.AddWithValue("@price", 110000);
        command.Parameters.AddWithValue("@desc", "new laptopm from sample");
        command.Parameters.AddWithValue("@cid", 1);

        connection.Open();
        int res = command.ExecuteNonQuery();
        Console.WriteLine(res > 0 ? "added" : "failed");
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    finally
    {
        connection?.Close();
    }
}
