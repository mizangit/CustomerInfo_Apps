using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VivaTask.Model
{
    public class PhotoInfo
    {
        public string PhotoName { get; set; }
        public int PhotoSize { get; set; }
        public byte[] Photo { get; set; }

    }
}