using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JagratBharatNewsAdmin
{
    public partial class GetImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataDataContext db = new DataDataContext();
            int PostID = Convert.ToInt32(Request.QueryString["PostID"]);
            string Size = Request.QueryString["Size"].ToString().ToLower();

            var post = db.Posts.Where(n => n.Id == PostID).SingleOrDefault();
            if (post != null)
            {
                var img = GlobalMethods.BinaryToImage(post.Image.ToArray());
                var imgArray = GetBytesFromImage(generateImage(img, Size));
                AddToResponse(imgArray, post.Id);
            }
        }
        public void AddToResponse(byte[] imageArray, int ID)
        {
            MemoryStream memoryStream = new MemoryStream(imageArray);
            Response.ContentType = "image/jpg";
            Response.Buffer = true;
            Response.AddHeader("Content-Disposition", "inline; filename=\"" + ID + ".jpg\"");
            Response.ContentType = "image/jpg";
            memoryStream.WriteTo(Context.Response.OutputStream);
            Response.Flush();
            Response.End();
        }
        public System.Drawing.Image generateImage(System.Drawing.Image img, string size)
        {
            if (size == "thumbnail")
            {
                var newSize = new Size
                {
                    Width = 80,
                    Height = 40
                };
                var newImage = new Bitmap(newSize.Width, newSize.Height);
                using(var g = Graphics.FromImage(newImage))
                {
                    g.DrawImage(img, 0, 0, newSize.Width, newSize.Height);
                }
                return newImage;

            }
            else
            {
                return img;
            }
        }
        public byte[] GetBytesFromImage(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();            
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }
    }
}