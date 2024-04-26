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
    internal class RotationImple:BaseImple, RotationI
    {
        public int Delete(Rotation t)
        {
            query = @"UPDATE Rotation SET status=0, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
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
        public int Insert(Rotation t)
        {
            query = @"INSERT INTO Rotation(startDate, idEmploye, idJob, byUser)
                      VALUES (@startDate, @idEmploye, @idJob, @byUser)";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@startDate", t.InitialDate);
            command.Parameters.AddWithValue("@idEmploye", t.PersonID);
            command.Parameters.AddWithValue("@idJob", t.JobID);
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
            query = @"SELECT id, startDate AS 'Fecha de Rotacion'
                        FROM Rotation
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
        public int Update(Rotation t)
        {
            query = @"UPDATE Job SET startDate= @startDate, idEmploye= @idEmploye, idJob= @idJob, lastUpdate=CURRENT_TIMESTAMP, userID=@userID
                      WHERE id=@id";
            SqlCommand command = CreateBasicCommand(query);
            command.Parameters.AddWithValue("@startDate", t.InitialDate);
            command.Parameters.AddWithValue("@idEmploye", t.PersonID);
            command.Parameters.AddWithValue("@idJob", t.JobID);
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
