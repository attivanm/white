using System.Data;
using System.Data.SqlClient;

namespace Northwind.Dal
{
    public static class DalManager
    {
        const string ConnectionString = @"Server=(localdb)\v11.0;Database=Northwind;Trusted_Connection=true;";

        public static void ClearDatabase()
        {
            string query = @"
                DELETE FROM [dbo].[ProjectInvolement];
                DELETE FROM [dbo].[Employee];
                DELETE FROM [dbo].[Department];
                DELETE FROM [dbo].[Project];";

            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnn)
                {
                    CommandType = CommandType.Text
                };

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
