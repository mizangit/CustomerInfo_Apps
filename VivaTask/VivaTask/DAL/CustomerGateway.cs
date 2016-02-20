using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using VivaTask.UI;
using VivaTask.Model;

namespace VivaTask.DAL
{
    public class CustomerGateway
    {
        int affectedRow = -1;
        string connectionDB = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
        public int Insert(Model.Customer aCustomer)
        {

            SqlConnection aConnection = new SqlConnection(connectionDB);

            SqlCommand aCommand = new SqlCommand("proImageStore",aConnection);

            aCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter paraName = new SqlParameter("@Name", aCustomer.Name);
            aCommand.Parameters.Add(paraName);

            SqlParameter paraPhone = new SqlParameter("@Phone", aCustomer.Phone);
            aCommand.Parameters.Add(paraPhone);
            SqlParameter paraDate = new SqlParameter("@Date", aCustomer.Date);
            aCommand.Parameters.Add(paraDate);
            SqlParameter paraPhoto = new SqlParameter("@Photo", aCustomer.Photo);
            aCommand.Parameters.Add(paraPhoto);

            aConnection.Open();
           
            affectedRow = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return affectedRow;
        }
    }
}