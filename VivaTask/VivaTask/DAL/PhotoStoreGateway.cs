using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using VivaTask.Model;
using System.IO;
using System.Data;


namespace VivaTask.DAL
{
    public class PhotoStoreGateway
    {
        int affectedRow = -1;
        string connectionDB = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString;
        public int Insert(Model.PhotoInfo aPhotoInfo)
        {

            SqlConnection aConnection = new SqlConnection(connectionDB);

            SqlCommand aCommand = new SqlCommand("INSERT INTO tbl_Test2 (PhotoName,PhotoSize,Photo) VALUES('" + aPhotoInfo.PhotoName + "','" + aPhotoInfo.PhotoSize + "','" + aPhotoInfo.Photo + "')", aConnection);
            aConnection.Open();

            affectedRow = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return affectedRow;
        }

        internal int Insert(string PhotoName, int PhotoSize, byte[] Photo)
        {
            SqlConnection aConnection = new SqlConnection(connectionDB);

            SqlCommand cmd = new SqlCommand("spUploadImage", aConnection);
          //  cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramName = new SqlParameter()
            {
                ParameterName = @"Name",
                Value = PhotoName
            };
            cmd.Parameters.Add(paramName);

            SqlParameter paramSize = new SqlParameter()
            {
                ParameterName = "@Size",
                Value = PhotoSize
            };
            cmd.Parameters.Add(paramSize);

            SqlParameter paramImageData = new SqlParameter()
            {
                ParameterName = "@ImageData",
                Value = Photo
            };
            cmd.Parameters.Add(paramImageData);

            SqlParameter paramNewId = new SqlParameter()
            {
                ParameterName = "@NewId",
                Value = -1,
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(paramNewId);

            aConnection.Open();
            int message =cmd.ExecuteNonQuery();
            aConnection.Close();
            return message;
        }
    }
}