using System;
using System.Collections.Generic;
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
            var post = db.Posts.Where(n => n.Id == PostID).SingleOrDefault();
            if (post != null)
            {
                MemoryStream memoryStream = new MemoryStream(post.Image.ToArray());
                Response.ContentType = "image/jpg";
                Response.Buffer = true;
                Response.AddHeader("Content-Disposition", "inline; filename=\"" + post.Id + ".jpg\"");
                Response.ContentType = "image/jpg";
                memoryStream.WriteTo(Context.Response.OutputStream);
                Response.Flush();
                Response.End();
            }
        }
    }
}