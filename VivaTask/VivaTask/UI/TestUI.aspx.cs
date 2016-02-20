using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VivaTask.Model;
using VivaTask.BLL;
using VivaTask.DAL;

namespace VivaTask.UI
{
    public partial class TestUI : System.Web.UI.Page
    {
        CustomerGateway aGateway = new CustomerGateway();
        public void Page_Load(object sender, EventArgs e)
        {

        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();

            aCustomer.Name = nameTextBox.Text;
            aCustomer.Phone = int.Parse(phoneTextBox.Text);
            aCustomer.Date = DateTime.Parse(dobTextBox.Text);


            HttpPostedFile postedFile = photoFileUpload.PostedFile;
            string FileName = Path.GetFileName(postedFile.FileName);
            string FileFormat = Path.GetExtension(FileName);

            
            if (FileFormat.ToLower() == ".jpg" || FileFormat.ToLower() == ".gif"
                || FileFormat.ToLower() == ".png" || FileFormat.ToLower() == ".bmp")
            {
                Stream aStream= postedFile.InputStream;
                BinaryReader aBinaryReader = new BinaryReader(aStream);
                aCustomer.Photo = aBinaryReader.ReadBytes((int)aStream.Length);

               int message=  aGateway.Insert(aCustomer);
                 
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