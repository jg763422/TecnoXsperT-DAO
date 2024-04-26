using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecnoXsperT_ADO.Interface;
using TecnoXsperT_ADO.Model;

namespace TecnoXsperT_ADO.Implementation
{
    internal class JobImple:BaseImple, JobI
    {
        public int Delete(Job t)
        {
            query = @"UPDATE Job SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Insert(Job t)
        {
            query = @"INSERT INTO Job(name, description, baseSalary, userID)
                      VALUES(@name, @description, @baseSalary, @userID)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Name);
            command.Parameters.AddWithValue("@baseSalary", t.Description);
            command.Parameters.AddWithValue("@userID", 1);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Select()
        {
            query = @"SELECT id, name AS 'Nombre del Cargo'
                        FROM Job
                        ORDER BY 2";
            SqlCommand command = CreateBasicCommand(query);
            try
            {
                return ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update(Job t)
        {
            query = @"UPDATE Job SET name=@name, description=@description, baseSalary=@baseSalary, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@name", t.Name);
            command.Parameters.AddWithValue("@description", t.Name);
            command.Parameters.AddWithValue("@baseSalary", t.Description);
            command.Parameters.AddWithValue("@userID", 1);
            command.Parameters.AddWithValue("@id", t.Id);
            try
            {
                return ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
