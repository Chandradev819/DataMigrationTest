using System.Data;
using System.Data.SqlClient;

namespace DataMigrationTest.DAL
{
    public class DataDAL
    {
        public async Task<string> SaveDataAsync(string data, IConfiguration config)
        {
            try
            {
                string connString = config.GetConnectionString("DefaultConnection");
                await using (var sqlConnection = new SqlConnection(connString))
                {
                    await using (var sqlCommand = sqlConnection.CreateCommand())
                    {
                        await sqlConnection.OpenAsync();
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCommand.CommandText = "sp_saveData";
                        sqlCommand.Parameters.AddWithValue("@Data ", data);
                      
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        sqlCommand.Parameters.Add(returnValue);
                        await sqlCommand.ExecuteNonQueryAsync();
                        return "data has been saved successfully";
                    }
                }
            }
            catch (Exception ex)
            {
                string es = ex.ToString();
                throw;
            }
        }
    }
}
