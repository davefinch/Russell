using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Russell
{
    public class Sql : IDisposable
    {
        /// <summary>
        /// Indicate if object has been disposed or not. This is to allow Dispose to be called multiple times without crashing
        /// </summary>
        /// 
        private bool _isDisposed = false;

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Dispose method for class</summary>
        /// 
        /// <param name='disposing'>Indicates if disposing or not</param>
        /// 
        /// <returns>void</returns>
        ///
        /// <remarks>
        /// Free up all the managed and un-managed resources. I have dealt with these in code so nothing to do here at moment
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        protected void Dispose(bool disposing)
        {
            // Get out of here if disposed already
            if (_isDisposed) return;

            // Do we Need to Free Managed Resources we have none as using block used 
            if (disposing)
            {
                // Put code in here to close down managed resources such as DB connection. 
            }

            // Clean up all unmanged resources here
            // We have none as all are managed in using blocks anyway
            _isDisposed = true;
        }

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Dispose method for class</summary>
        /// 
        /// <returns>void</returns>
        ///
        /// <remarks>
        /// Free up all the managed and un-managed resources. I have dealt with these in code so nothing to do here at moment
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        public void Dispose()
        {
            Dispose(true);
        }

        /// ----------------------------------------------------------------------------------------------------------------------------
        /// <summary>Provides details reagrdaing the class</summary>
        /// 
        /// <returns>Information reagrding the class</returns>
        ///
        /// <remarks>
        /// Overide the existing ToString() method to provide additional information on the class
        /// </remarks>
        /// ----------------------------------------------------------------------------------------------------------------------------
        public override string ToString()
        {
            return "Sql Class";
        }

        public DataJob GetJobs()
        {
            // Assign Empty Values


            List<DataJob> listDataJob = new List<DataJob>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT j.JobId, j.EmployeeId, e.FirstName, e.LastName, j.AgencyId, a.AgencyName, j.JobDetails, ");
                    sb.AppendLine("j.StartJob, j.EndJob, j.hours, j.Rate, j.PaymentReceivedDate, j.TotalPaymentReceived  ");
                    sb.AppendLine("FROM Job j INNER JOIN ");
                    sb.AppendLine("Employee e ON e.EmployeeId = j.EmployeeId INNER JOIN ");
                    sb.AppendLine("Agency a ON a.AgencyId = j.AgencyId");
                    sb.AppendLine("ORDER BY j.StartJob DESC");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    //comm.Parameters.Clear();
                    //comm.Parameters.AddWithValue("@RegNumber", regNumber);

                    DataJob dj = new DataJob();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        sb.Clear();
                        DateTime date;

                        while (reader.Read())
                        {
                            // Assign our Output Variables
                            dj.JobId = Convert.ToInt32(reader["JobId"]);

                            dj.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                            dj.EmployeeFirstName = reader["FirstName"].ToString();
                            dj.EmployeeLastName = reader["LastName"].ToString();

                            dj.AgencyId = Convert.ToInt32(reader["AgencyId"]);
                            dj.AgencyName = reader["AgencyName"].ToString();

                            dj.JobDetails = reader["JobDetails"].ToString();

                            int ordinal = reader.GetOrdinal("StartJob");
                            dj.StartJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["StartJob"]);
                            ordinal = reader.GetOrdinal("EndJob");
                            dj.EndJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["EndJob"]);

                            dj.Hours = Convert.ToInt32(reader["Hours"]);
                            dj.Rate = Convert.ToDecimal(reader["Rate"]);

                            ordinal = reader.GetOrdinal("PaymentReceivedDate");
                            dj.EndJob = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDateTime(reader["PaymentReceivedDate"]);
                            //ordinal = reader.GetOrdinal("TotalPaymentReceived");
                            //dj.TotalPaymentReceived = reader.IsDBNull(ordinal) ? (DateTime?)null : Convert.ToDecimal(reader["TotalPaymentReceived"]);


                            // Add to the DataRecord
                            listDataJob.Add(dj);

                        }
                    }

                    return dj;

                }

            }

        }


        public int InsertNewJob(DataJob dj)
        {
            int newJobId = 0;
            List<DataJob> listDataJob = new List<DataJob>();

            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("INSERT INTO Job (EmployeeId, AgencyId, JobDetails, StartJob, Endjob, Hours, Rate, PaymentReceivedDate, TotalPaymentReceived) ");
                    sb.AppendLine("OUTPUT Inserted.JobId ");
                    sb.AppendLine("VALUES (@EmployeeId, @AgencyId, @JobDetails, @StartJob, @EndJob, @Hours, @Rate, @PaymentReceivedDate, @TotalPaymentReceived) ");
                    
                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;
                    comm.Parameters.Clear();
                    comm.Parameters.AddWithValue("@EmployeeId", dj.EmployeeId);
                    comm.Parameters.AddWithValue("@AgencyId", dj.AgencyId);
                    comm.Parameters.AddWithValue("@JobDetails", dj.JobDetails);
                    comm.Parameters.AddWithValue("@StartJob", dj.StartJob);
                    comm.Parameters.AddWithValue("@Endjob", dj.EndJob);
                    comm.Parameters.AddWithValue("@Hours", dj.Hours);
                    comm.Parameters.AddWithValue("@Rate", dj.Rate);
                    comm.Parameters.AddWithValue("@PaymentReceivedDate", dj.EmployeeId);
                    comm.Parameters.AddWithValue("@TotalPaymentReceived", dj.EmployeeId);

                    newJobId = Convert.ToInt32(comm.ExecuteScalar());

                    return newJobId;

                }

            }

        }


        public Dictionary<string, int> GetAgencies()
        {
            using (SqlConnection conn = new SqlConnection(Constants.ConnectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("SELECT AgencyName, AgencyId ");
                    sb.AppendLine("FROM Agency ");
                    sb.AppendLine("ORDER BY AgencyName");

                    comm.CommandText = sb.ToString();
                    comm.Connection = conn;

                    Dictionary<string, int> agencies = new Dictionary<string, int>();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            agencies.Add(reader["AgencyName"].ToString(), Convert.ToInt32(reader["AgencyId"]));
                        }
                    }
                    return agencies;
                }

            }
        }










    }

}


