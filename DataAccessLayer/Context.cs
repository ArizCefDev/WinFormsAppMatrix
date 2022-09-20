using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Context
    {
        private const string ConString = @"server=WIN-V45TJ7IL2H4; database=MatrixDB; Trusted_Connection=true; Encrypt=false;";

        private static  SqlConnection SqlConnection { get; set; }
        private static  SqlCommand SqlCommand { get; set; }
        private static  SqlDataAdapter SqlDataAdapter { get; set; }

        public static void RunExecute(string cmd)
        {
            try
            {
                SqlConnection = new SqlConnection(ConString);
                SqlConnection.Open();
                SqlCommand = new SqlCommand(cmd,SqlConnection);
                SqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        public static DataSet RunSelect(string cmd)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlConnection = new SqlConnection(ConString);
                SqlConnection.Open();

                SqlCommand = new SqlCommand(cmd, SqlConnection);

                SqlDataAdapter = new SqlDataAdapter(SqlCommand);

                SqlDataAdapter.Fill(dataSet);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                SqlConnection.Close();
            }
            return dataSet;
        }


    }
}
