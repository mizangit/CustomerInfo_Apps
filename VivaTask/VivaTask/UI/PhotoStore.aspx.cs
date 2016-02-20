using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using VivaTask.Model;
using VivaTask.DAL;

namespace VivaTask.UI
{
    public partial class PhotoStore : System.Web.UI.Page
    {

        PhotoStoreGateway aPhotoStoreGateway = new PhotoStoreGateway();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

         
            HttpPostedFile postedFile = photoFileUpload.PostedFile;
            string PhotoName = Path.GetFileName(postedFile.FileName);
            string FileFormat = Path.GetExtension(PhotoName);
            int PhotoSize = postedFile.ContentLength;


            if (FileFormat.ToLower() == ".jpg" || FileFormat.ToLower() == ".gif"
                || FileFormat.ToLower() == ".png" || FileFormat.ToLower() == ".bmp")
            {
                Stream aStream = postedFile.InputStream;
                BinaryReader aBinaryReader = new BinaryReader(aStream);
                byte[] Photo = aBinaryReader.ReadBytes((int)aStream.Length);

                int message = aPhotoStoreGateway.Insert(PhotoName, PhotoSize, Photo);

                if (message > 0)
                {
                    messLabel.Text = "Data saved successfully";
                }
                else
                {
                    messLabel.Text = "Data not save";
                }

            }
            else
            {
                messLabel.Text = "Invalid image Format";
            }
        }
    }
}