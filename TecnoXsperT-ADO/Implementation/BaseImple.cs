using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnoXsperT_ADO.Implementation
{
    internal class BaseImple
    {
        string connetionString = "Server=ASUS-JMGR\\MSSQLSERVER2;Database=bddpersonas;Trusted_Connection=True;";
        public string query;
        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
        public SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }
        public int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable dt = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adacter = new SqlDataAdapter(command);
                adacter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
            return dt;
        }
    }
}
